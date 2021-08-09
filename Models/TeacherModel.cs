using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace OrienteeringApi.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }

        public int SchoolId { get; set; }

        public SchoolModel School { get; set; }

        public virtual List<LessonGroupSessionModel> LessonGroupSessions { get; set; } = new List<LessonGroupSessionModel>();

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}