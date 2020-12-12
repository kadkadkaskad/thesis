using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FlagHunter.Api.Models;

namespace FlagHunter.Api.Services.Interfaces
{
    public interface IDockerService
    {
        Task<string[]> ListServices();

        Task<string> StartService(Guid studentId, Guid testId, string imageId, string port);
        Task<bool> StopService(string serviceId);
        Task<string> GetServiceByIds(Guid studentId, Guid testId);
        Task<bool> ValidateCTest();
    }
}
