using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Models
{
    public class CreateTestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Solution { get; set; }
        public string SolutionFile { get; set; }
        public string PathToSolvables { get; set; }
    }
}
