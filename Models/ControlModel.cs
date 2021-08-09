using System;
using System.ComponentModel.DataAnnotations;

namespace OrienteeringApi.Models
{
    public class ControlModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ImagePath { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}