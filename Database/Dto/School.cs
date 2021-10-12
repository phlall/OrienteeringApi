using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class School
    {
        public int Id { get; set; }

        public virtual List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public virtual List<Pupil> Pupils { get; set; } = new List<Pupil>();

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public virtual List<LessonGroup> LessonGroups { get; set; } = new List<LessonGroup>();
        public string  Address { get; set; }
        [Required]
        [StringLength(50)]
        public string Postcode { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}
