using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class QaRepository : RepositoryBase<QA>, IQaRepository
    {
        private readonly OrienteeringContext _context;
        public QaRepository(OrienteeringContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<QA>> GetQuestions(int subjectId)
        {
            return await _context.QAs.Where(x => x.LessonSubjectId == subjectId).OrderBy(o => o.Question).ToListAsync();
        }
        public async Task<LessonSubject> GetLessonSubjectByName(string subject)
        {
            return await _context.LessonSubjects.FirstOrDefaultAsync(x => x.Name == subject);
        }
        public async Task<LessonSubject> GetLessonSubject(int id)
        {
            return await _context.LessonSubjects.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
