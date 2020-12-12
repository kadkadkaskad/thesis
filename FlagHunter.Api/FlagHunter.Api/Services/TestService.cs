using AutoMapper;
using FlagHunter.Api.Entities;
using FlagHunter.Api.Models;
using FlagHunter.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services
{
    public class TestService : ITestService
    {
        private readonly FlagHunterDbContext _context;
        private readonly IMapper _mapper;
        public TestService(FlagHunterDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateTest(CreateTestDto testDto, string imageId)
        {
            var test = _mapper.Map<Test>(testDto);
            test.ImageId = imageId;

            await _context.AddAsync(test);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Test> GetTestById(Guid testId)
        {
            return await _context.Tests.Where(x => x.Id == testId).FirstOrDefaultAsync();
        }

        public async Task<StudentTest> GetStudentTestByIds(Guid studentId, Guid testId)
        {
            return await _context.StudentTests.Where(x => x.StudentId == studentId && x.TestId == testId).FirstOrDefaultAsync();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }


    }
}
