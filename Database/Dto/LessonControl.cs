using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class LessonControl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int LessonGroupId { get; set; }
        public LessonGroup LessonGroup { get; set; }

        public List<LessonGroupSessionAnswers> LessonGroupSessionAnswers { get; set; } = new List<LessonGroupSessionAnswers>();
        //public int ControlId { get; set; }

        //public Control Control { get; set; }

        //public int MapId { get; set; }

        //public Map Map { get; set; }

        public int YPos { get; set; }

        public int XPos { get; set; }

        public int QAId { get; set; }

        public QA QuestionAnswer { get; set; }

        //public string Answer { get; set; }

        //public string Question { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
