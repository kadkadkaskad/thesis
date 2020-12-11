using FlagHunter.Api.Entities;
using FlagHunter.Api.Models;
using FlagHunter.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services
{
    public class StudentService : IStudentService
    {
        private readonly FlagHunterDbContext _context;

        public StudentService(FlagHunterDbContext context)
        {
            _context = context;
        }

        public async Task<Student> GetStudentByUserName(string username)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<IList<Test>> GetStudentTests(Guid studentId)
        {
            return await _context.Tests.Where(x => x.StudentTests.Any(st => st.StudentId == studentId ))
                .ToListAsync();
        }

        public bool StudentExists(Expression<Func<Student, bool>> expr)
        {
            return _context.Students.Any(expr);
        }
    }
}
