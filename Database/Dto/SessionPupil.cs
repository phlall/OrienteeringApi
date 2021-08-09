using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class SessionPupil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int LessonGroupSessionId { get; set; }

        public LessonGroupSession LessonGroupSession { get; set; }

        public int PupilId { get; set; }

        public Pupil Pupil { get; set; }

        public int QAId { get; set; }

        public QA QA { get; set; }

        public string PupilAnswer { get; set; }

        public DateTime CompletedIn { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
