using FlagHunter.Api.Entities;
using FlagHunter.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services.Interfaces
{
    public interface IStudentService
    {
        bool StudentExists(Expression<Func<Student, bool>> expr);
        Task<Student> GetStudentByUserName(string username);
        Task<IList<Test>> GetStudentTests(Guid studentId);
    }
}
