using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class LessonGroupRepositiory : RepositoryBase<LessonGroup>, ILessonGroupRepository
    {
        private readonly OrienteeringContext _context;
        public LessonGroupRepositiory(OrienteeringContext context) : base(context) {
            _context = context;
        }

        public async Task<LessonGroup[]> GetLessonGroupsBySchoolId(int schoolId)
        {
            IQueryable<LessonGroup> query = _context.LessonGroups.Where(x => x.SchoolId == schoolId).Include(x => x.LessonGroupSessions).Include(x => x.LessonSubject);
            return await query.ToArrayAsync();
        }
    }
}
