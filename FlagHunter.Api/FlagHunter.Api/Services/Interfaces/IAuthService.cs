using FlagHunter.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> Login(string username, string password);
    }
}
