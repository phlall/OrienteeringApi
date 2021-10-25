using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Models
{ 

    public class NewMapModel
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        //[StringLength(100)]
        //public int SchoolId { get; set; }
        //public SchoolModel School { get; set; }

        public MapImageModel MapImage { get; set; }
        //public string Image { get; set; }
        public string Description { get; set; }

        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;

        public virtual List<MapNodeModel> MapNodes { get; set; } = new List<MapNodeModel>();
       // public List<LessonGroupModel> LessonGroups { get; set; } = new List<LessonGroupModel>();
    }
}
