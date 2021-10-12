using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Models
{

    public class MapImageModel
    {
        public int Id { get; set; }

        [Required]
        public int SchoolId { get; set; }
        public SchoolModel School { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public List<MapModel> Maps { get; set; } = new List<MapModel>();
    }
}
