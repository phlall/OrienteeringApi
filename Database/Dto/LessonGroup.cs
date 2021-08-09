using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models;

namespace OrienteeringApi.Database
{
    public class LessonGroup 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int LessonSubjectId { get; set; }

        public LessonSubject LessonSubject { get; set; }

        public List<LessonGroupSession> LessonGroupSessions { get; set; } = new List<LessonGroupSession>();

        public int SchoolId { get; set; }

        public int MapId { get; set; }

        public Map Map { get; set; }

        public School School { get; set; }

        public string AgeGroup { get; set; }

        public bool  Shared { get; set; }

        [StringLength(200)]
        public string Equipment  { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public string Intro { get; set; }

        public string Warmup { get; set; }

        public string MainSession { get; set; }

        public string GameBasedLearning { get; set; }

        public string Conclusion { get; set; }

        public virtual List<LessonControl> LessonControls { get; set; } = new List<LessonControl>();

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }


    }
}
