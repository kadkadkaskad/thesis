using FlagHunter.Api.Entities;
using FlagHunter.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services.Interfaces
{
    public interface ITestService
    {
        Task<bool> CreateTest(CreateTestDto testDto, string imageId);
        Task<Test> GetTestById(Guid testId);

        Task<StudentTest> GetStudentTestByIds(Guid studentId, Guid testId);
    }
}
