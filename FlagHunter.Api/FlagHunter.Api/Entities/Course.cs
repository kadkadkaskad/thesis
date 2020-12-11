using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Entities
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string CourseId { get; set; }
        public string Name { get; set; }

        // Relationships
        public ICollection<Test> Tests { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
