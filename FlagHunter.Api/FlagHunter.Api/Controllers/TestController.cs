using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using FlagHunter.Api.Models;
using FlagHunter.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagHunter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IDockerService _dockerService;
        private readonly ITestService _testService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly FlagHunterDbContext _context;
        public TestController(IDockerService dockerService, ITestService testService, IMapper mapper, IHttpContextAccessor httpContextAccessor, FlagHunterDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _dockerService = dockerService;
            _testService = testService;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet("ListServices")]
        public async Task<ActionResult<string[]>> ListServices()
        {
            var response = await _dockerService.ListServices();
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest();
        
        }

        [HttpGet("{id}/Start")]
        public async Task<string> StartEnvironment(Guid id)
        {
            var currentUserGuid = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var test = await _testService.GetTestById(id);
            var res = await _dockerService.StartService(new Guid(currentUserGuid), test.Id, test.ImageId, test.ImagePort);
            if (res != null)
            {
                return res;
            }
            return null;
        }

        [HttpGet("{environmentId}/Stop")]
        public async Task<bool> StopEnvironment(string environmentId)
        {
            return await _dockerService.StopService(environmentId);
        }

        [HttpGet("{testId}/Environment")]
        public async Task<string> GetEnvironmentId(Guid testId)
        {
            var currentUserGuid = new Guid(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            
            return await _dockerService.GetServiceByIds(currentUserGuid, testId);
        }
        [HttpGet("{testId}/ValidateCTest")]
        public async Task<bool> ValidateCTest(string testId)
        {
            var currentUserGuid = new Guid(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var studentTest = await _testService.GetStudentTestByIds(currentUserGuid, new Guid(testId));
            var passed = await _dockerService.ValidateCTest();

            if (passed)
            {
                studentTest.Solved = true;
                await _context.SaveChangesAsync();
            }
            return passed;
        }

        [HttpGet("{id}")]
        public async Task<TestDto> GetTestDetails(Guid id)
        {
            var test = await _testService.GetTestById(id);
            return _mapper.Map<TestDto>(test);
        }
           
    }
}