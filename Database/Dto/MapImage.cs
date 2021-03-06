using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{

    public class MapImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int SchoolId { get; set; }
        public School School { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public List<Map> Maps { get; set; } = new List<Map>();
    }
}
