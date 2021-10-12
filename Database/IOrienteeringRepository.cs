using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public interface IOrienteeringRepository
    {
        Task<LessonControl[]> GetControls();
        Task<List<LessonControl>> GetLessonControlsBylessonId(int id);

        Task<LessonControl> GetControlLessonById(int id);
        Task<LessonControl[]> GetControlLessonsById(int id);
        Task<LessonControl[]> GetControlLessons();
        Task<LessonGroup[]> GetLessonGroups();

        Task<LessonGroup[]> GetLessonGroups(int schoolId);

        Task<LessonGroup> GetLessonGroup(int id);

        Task<LessonSubject[]> GetLessonSubjects();

        //Task<LessonSubject> GetLessonSubjectByName(string subject);

        Task<LessonSubject> GetLessonSubject(int id);

        Task<LessonGroup> AddLessonGroup(LessonGroup group);
        Task<LessonGroupSession[]> getGroupSessions(int id);
        //Task<MapNode[]> GetMaps();

        //Task<MapNode> GetMap(int id);

        //Task<MapNode[]> GetMapsBySchoolId(int schoolId);

        //Task<List<QA>> GetQuestions(int subjectId);

        Task<School> GetSchool(int id);

        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        Task<QA> GetQA(int id);

        Task<QA[]> GetQAs();
        Task<bool> SaveChangesAsync();
       
    }
}
