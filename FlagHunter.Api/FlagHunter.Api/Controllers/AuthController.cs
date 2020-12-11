using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using FlagHunter.Api.Configurations;
using FlagHunter.Api.Models;
using FlagHunter.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace FlagHunter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService, IOptions<AppSettings> appSettings)
        {
            _authService = authService;
            _appSettings = appSettings.Value;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto loginUser)
        {
            var user = await _authService.Login(loginUser.UserName, loginUser.Password);
            if (user == null)
            {
                return BadRequest("Username or password is incorrect!");
            }

            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var claimsIdenetity = new ClaimsIdentity(claims);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdenetity,
                Expires = DateTime.UtcNow.AddMinutes(20),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Token)), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new { tokenString });
        }
    }
}