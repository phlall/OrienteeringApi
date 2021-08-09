using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Models
{ 

    public class MapModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public int SchoolId { get; set; }
        public SchoolModel School { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public List<LessonGroupModel> LessonGroupModels { get; set; }
    }
}
