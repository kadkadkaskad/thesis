using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlagHunter.Api.Entities
{
    public class Test
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Docker image related properties
        public string ImageId { get; set; }
        public string ImagePort { get; set;} 

        // Relationships
        public Guid CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<StudentTest> StudentTests { get; set; }
    }
}
