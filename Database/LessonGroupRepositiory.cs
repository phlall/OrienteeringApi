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

        public async Task<LessonGroup> GetLessonGroupFull(int id)
        {
            LessonGroup lg = await _context.LessonGroups.Include(l => l.LessonSubject).Include(m => m.Map).ThenInclude(mi => mi.MapImage).Include(i => i.LessonControls).ThenInclude(ic => ic.MapNode)
                .Include(i => i.LessonControls).ThenInclude(ti => ti.QuestionAnswer).FirstOrDefaultAsync(x => x.Id == id);
            return lg;
        }

        public async Task<LessonGroup[]> GetLessonGroupsBySchoolId(int schoolId)
        {
            IQueryable<LessonGroup> query = _context.LessonGroups.Where(x => x.SchoolId == schoolId).Include(x => x.LessonGroupSessions).Include(x => x.LessonSubject);
            return await query.ToArrayAsync();
        }
    }
}
