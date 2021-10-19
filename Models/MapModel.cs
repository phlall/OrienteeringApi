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
        //[Required]
        //[StringLength(100)]
        //public int SchoolId { get; set; }
        //public SchoolModel School { get; set; }

        public MapImageChildModel MapImage { get; set; }
        //public string Image { get; set; }
        //public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;

        public virtual List<MapNodeChildModel> MapNodes { get; set; } = new List<MapNodeChildModel>();
       // public List<LessonGroupModel> LessonGroups { get; set; } = new List<LessonGroupModel>();
    }
}
