using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database { 
    public class LessonGroupSessionAnswers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int LessonGroupSessionId { get; set; }

        public LessonGroupSession LessonGroupSession { get; set; }

        public int LessonControlId { get; set; }

        public LessonControl LessonControl { get; set; }

        public int PupilId { get; set; }

        public Pupil Pupil { get; set; }

        public string PupilAnswer { get; set; }

        public DateTime AnswerDate { get; set; }


    }
}
