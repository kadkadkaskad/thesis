using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Entities
{
    public class StudentTest
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid TestId { get; set; }
        public Test Test { get; set; }
        public bool Solved { get; set; }
        public bool Active { get; set; }
    }
}
