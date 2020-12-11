using FlagHunter.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services.Interfaces
{
    public interface ITeacherService
    {
        bool TeacherExists(Expression<Func<Teacher, bool>> expr);
        Task<Teacher> GetTeacherByUserName(string username);
    }
}
