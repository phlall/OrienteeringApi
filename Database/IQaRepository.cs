using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public interface IQaRepository : IRepositoryBase<QA>
    {
        Task<List<QA>> GetQuestions(int subjectId);

        Task<LessonSubject> GetLessonSubjectByName(string subject);

        Task<LessonSubject> GetLessonSubject(int id);

        Task<QA[]> GetBySubject(int id);
    }
}
