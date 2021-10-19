using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class LessonSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<QA> QAs { get; set; } = new List<QA>();

        public List<LessonGroup> LessonGroups { get; set; } = new List<LessonGroup>();

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ThemeImage { get; set; }

        [Required]
        [StringLength(200)]
        public string AgeGroup { get; set; }
        public bool IsActive { get; set; }
        public bool IsPremium { get; set; }
        public bool IsShared { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}
