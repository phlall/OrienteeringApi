using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Models
{

    public class MapNodeChildModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        [Required]
        public int YPos { get; set; }

        [Required]
        public int XPos { get; set; }

       // public virtual List<LessonControlModel> LessonControls { get; set; } = new List<LessonControlModel>();

    }
}
