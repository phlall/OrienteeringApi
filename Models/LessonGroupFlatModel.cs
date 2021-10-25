using OrienteeringApi.Database;
using OrienteeringApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrienteeringApi.Models
{
    public class LessonGroupFlatModel
    {
        public int Id { get; set; }
        // public int LessonSubjectId { get; set; }

        public int LessonSubjectId { get; set; }

        public string LessonSubject { get; set; }

        public string AgeGroup { get; set; }

        public int SchoolId { get; set; }

        public MapModel Map { get; set; }

        public int MapId { get; set; }

        //public string MapTitle { get; set; }

        //public string MapDescription { get; set; }

        public bool Shared { get; set; }

        [StringLength(200)]
        public string Equipment { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public string Intro { get; set; }

        public string Warmup { get; set; }

        public string MainSession { get; set; }

        public string GameBasedLearning { get; set; }

        public string Conclusion { get; set; }

        public virtual List<LessonControlFlatModel> Nodes { get; set; } = new List<LessonControlFlatModel>();

        public int LessonGroupSessions { get; set; }

        public DateTime Created { get; set; }

    }
}