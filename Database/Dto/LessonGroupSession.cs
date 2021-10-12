using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class LessonGroupSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LessonGroupId { get; set; }
        public LessonGroup LessonGroup { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<LessonGroupSessionAnswers> LessonGroupSessionAnswers { get; set; } = new List<LessonGroupSessionAnswers>();
        public DateTime Completed { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;
    }
}
