using FlagHunter.Api.Models;
using FlagHunter.Api.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlagHunter.Api.Services
{
    // Custom Python API wrapper for the easier communication with the Docker Swarm cluster
    public class DockerService : IDockerService
    {
        private readonly HttpClient _client;
        public DockerService(IHttpClientFactory httpClientFactory) 
        {
            _client = httpClientFactory.CreateClient("DockerAPI");
        }

        public async Task<string> StartService(Guid studentId, Guid testId, string imageId, string port)
        {
            var data = new 
            {
                s_id = studentId,
                t_id = testId,
                image=imageId,
                backend_port=port
            };

            var serializedData = JsonConvert.SerializeObject(data);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("/api/InitializeContainerEnvironment", content);

            if (res.IsSuccessStatusCode)
            {
                var resContent = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<string>(resContent);
            }
            return null;
        }

        public async Task<string[]> ListServices() 
        {
            var res = await _client.GetAsync("/api/ListServices");
            if (res.IsSuccessStatusCode) 
            {
                var content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<string[]>(content);
            }
            return null;
        }
        public async Task<string> GetServiceByIds(Guid studentId, Guid testId)
        {
            
            var data = new {
                s_id = studentId.ToString(),
                t_id = testId.ToString()
            };
            
            var serializedData = JsonConvert.SerializeObject(data);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("/api/Service", content);
            if(res.IsSuccessStatusCode)
            {
                var resContent = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<string>(resContent);
            }
            return null;
        }

        public async Task<bool> StopService(string serviceId)
        {
            var res = await _client.GetAsync("/api/Service/" + serviceId + "/Stop");
            if (res.IsSuccessStatusCode)
            {
                var content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<bool>(content);
            }
            return false;
        }

    }
}
