using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{

    public class MapNode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int MapId { get; set; }
        public Map Map { get; set; }

        public string Description { get; set; }

        [Required]
        public int YPos { get; set; }

        [Required]
        public int XPos { get; set; }

        public virtual List<LessonControl> LessonControls { get; set; } = new List<LessonControl>();

    }
}
