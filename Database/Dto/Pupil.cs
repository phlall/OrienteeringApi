using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class Pupil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public List<LessonGroupSessionAnswers> LessonGroupSessionAnswers { get; set; } = new List<LessonGroupSessionAnswers>();

        public int SchoolId { get; set; }

        public School School { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string YearGroup { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
