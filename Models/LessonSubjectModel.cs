using OrienteeringApi.Database;
using System;
using System.Collections.Generic;

namespace OrienteeringApi.Models
{
    public class LessonSubjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ThemeImage { get; set; }
        public bool IsActive { get; set; }
        public bool IsPremium { get; set; }
        public bool IsShared { get; set; }
        public bool IsPrivate { get; set; }

        public List<QAModel> QAs { get; set; } = new List<QAModel>();

        public List<LessonGroupModel> LessonGroups { get; set; } = new List<LessonGroupModel>();
    }
}