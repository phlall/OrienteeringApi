using System;

namespace OrienteeringApi.Models
{
    public class LessonControlModel
    {
    
        public int Id { get; set; }

        public int LessonGroupId { get; set; }

        //public int ControlId { get; set; }

        //public int MapId { get; set; }

        public int YPos { get; set; }

        public int XPos { get; set; }
        public QAModel QuestionAnswer { get; set; }

        //public string Answer { get; set; }

        //public string Question { get; set; }
        //public DateTime Created { get; set; }
        //public DateTime Modified { get; set; }
    }
}