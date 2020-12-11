using FlagHunter.Api.Configurations;
using FlagHunter.Api.Models;
using FlagHunter.Api.Services.Interfaces;
using Microsoft.Extensions.Options;
using Novell.Directory.Ldap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services
{
    public class LdapAuthService : IAuthService
    {
        private readonly LdapConfig _config;
        private readonly LdapConnection _connection;
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;

        public LdapAuthService(IOptions<LdapConfig> config, IStudentService studentService, ITeacherService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
            _config = config.Value;
            _connection = new LdapConnection() { SecureSocketLayer = false };
        }

        public async Task<User> Login(string username, string password)
        {
            _connection.Connect(_config.Url, LdapConnection.DefaultPort);
            _connection.Bind(_config.BindDn, _config.BindCredentials);

            var searchFilter = string.Format(_config.SearchFilter, username);
            var result = _connection.Search(
                _config.SearchBase,
                LdapConnection.ScopeSub,
                searchFilter,
                new[] { "uid", "gidNumber", },
                false
            );
            try
            {
                var user = result.Next();
                if (user != null)
                {
                    _connection.Bind(user.Dn, password);
                    if (_connection.Bound)
                    {
                        string role = null;
                        var groupId = user.GetAttribute("gidNumber").StringValue;
                        var userName = user.GetAttribute("uid").StringValue;

                        if (groupId == "3001")
                        {
                            role = "Teacher";
                            var teacher = await _teacherService.GetTeacherByUserName(userName);
                            if (teacher != null)
                                return new User { Id = teacher.Id, Role = role, UserName = userName };
                        }
                        else if (groupId == "3002")
                        {
                            role = "Student";
                            var student = await _studentService.GetStudentByUserName(userName);
                            if (student != null)
                                return new User { Id = student.Id, Role = role, UserName = userName };
                        }
                        else
                            return null; // If user not found in the database (or not already synced to the database
                    }
                }
            }
            catch
            {
                return null;
            }
            _connection.Disconnect();
            return null;
        }
    }
}
