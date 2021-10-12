using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{

    public class Map
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int MapImageId { get; set; }
        public MapImage MapImage { get; set; }
        //public string Image { get; set; }
        [Required]
        [StringLength(100)]
        //public string Title { get; set; }
        //public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public List<LessonGroup> LessonGroups { get; set; } = new List<LessonGroup>();

        public virtual List<MapNode> MapNodes { get; set; } = new List<MapNode>();


    }
}
