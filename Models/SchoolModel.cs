using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Models
{
    public class SchoolModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public List<TeacherModel> Teachers { get; set; } = new List<TeacherModel>();
        public List<MapModel> Maps { get; set; } = new List<MapModel>();
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
