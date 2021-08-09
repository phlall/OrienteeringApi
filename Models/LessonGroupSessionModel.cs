using OrienteeringApi.Database;
using System;

namespace OrienteeringApi.Models
{
    public class LessonGroupSessionModel
    {
        public int Id { get; set; }
        public int LessonGroupId { get; set; }
        //public LessonGroupModel LessonGroup { get; set; }
        public DateTime Completed { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}