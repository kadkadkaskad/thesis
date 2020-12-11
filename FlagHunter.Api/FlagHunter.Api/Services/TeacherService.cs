using FlagHunter.Api.Entities;
using FlagHunter.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly FlagHunterDbContext _context;

        public TeacherService(FlagHunterDbContext context)
        {
            _context = context;
        }

        public async Task<Teacher> GetTeacherByUserName(string username)
        {
            return await _context.Teachers.FirstOrDefaultAsync(t => t.UserName == username);
        }

        public bool TeacherExists(Expression<Func<Teacher, bool>> expr)
        {
            return _context.Teachers.Any(expr);
        }
    }
}
