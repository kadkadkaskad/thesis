using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using FlagHunter.Api.Entities;
using FlagHunter.Api.Models;
using FlagHunter.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlagHunter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStudentService _studentService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentController(IStudentService studentService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _studentService = studentService;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        [Route("Tests")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCurrentTests()
        {
            var currentUserGuid = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var tests = await _studentService.GetStudentTests(Guid.Parse(currentUserGuid));

            return Ok(_mapper.Map<IEnumerable<StudentTestDto>>(tests));
        }
    }
}