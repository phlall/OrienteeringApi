using OrienteeringApi.Database;
using System;
using System.Collections.Generic;

namespace OrienteeringApi.Models { 
    public class PupilModel
    {
         public int Id { get; set; }

        public List<LessonGroupSessionAnswers> LessonGroupSessionAnswers { get; set; } = new List<LessonGroupSessionAnswers>();

        public int SchoolId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string YearGroup { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}