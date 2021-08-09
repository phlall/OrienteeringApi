using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class SchoolRepository : RepositoryBase<School>, ISchoolRepository
    {
        private readonly OrienteeringContext _context;
        public SchoolRepository(OrienteeringContext context) : base(context) {
            _context = context;
        }

        public async Task<Pupil[]> GetPupils(int schoolId) 
        {
            var query = await _context.Schools.SelectMany(x => x.Pupils).Where(x => x.SchoolId == schoolId).ToArrayAsync();
            // var xx = await _context.Schools.FirstOrDefaultAsync(p => p.Teachers.Any(x => x.Id == teacherId));
            //IQueryable<School> query = _context.Schools.Find(schoolId);
            return query;
        }

        //public async Task<LessonGroup[]> GetLessonGroupsBySchoolId(int schoolId)
        //{
        //    IQueryable<LessonGroup> query = _context.LessonGroups.Where(x => x.SchoolId == schoolId).Include(x => x.LessonGroupSessions).Include(x => x.LessonSubject);
        //    return await query.ToArrayAsync();
        //}
    }
}
