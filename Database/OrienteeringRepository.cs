using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static OrienteeringApi.Database.OrienteeringContext;

namespace OrienteeringApi.Database
{
    public class OrienteeringRepository : IOrienteeringRepository
    {
        private readonly OrienteeringContext _context;
        public OrienteeringRepository(OrienteeringContext context)
        {
            _context = context;
        }
        public async Task<LessonControl[]> GetControls()
        {
            IQueryable<LessonControl> query = _context.LessonControls;
            return await query.ToArrayAsync();
        }
        public async Task<List<LessonControl>> GetLessonControlsBylessonId(int id)
        {
            //return  await  _context.LessonControls.Where(x => x.Id == id).Select(qa => qa.QuestionAnswer).ToListAsync();
            return await _context.LessonControls.Where(x => x.LessonGroupId == id).ToListAsync();
        }
        public async Task<LessonControl> GetControlLessonById(int id)
        {
           return await _context.LessonControls.FirstOrDefaultAsync(x => x.Id == id);
            //return await query.ToArrayAsync();
        }
        public async Task<LessonControl[]> GetControlLessonsById(int id)
        {
            IQueryable<LessonControl> query = _context.LessonControls.Where(x => x.LessonGroupId == id).Include(x => x.QuestionAnswer);
            return await query.ToArrayAsync();
        }
        public async Task<LessonControl[]> GetControlLessons()
        {
            IQueryable<LessonControl> query = _context.LessonControls; 
            return await query.ToArrayAsync();
        }

        public async Task<LessonGroup[]> GetLessonGroups()
        {
            IQueryable<LessonGroup> query = _context.LessonGroups;
            return await query.ToArrayAsync();
        }

        public async Task<LessonGroup[]> GetLessonGroups(int schoolId)
        {
            IQueryable<LessonGroup> query = _context.LessonGroups.Where(x => x.SchoolId == schoolId).Include(x => x.LessonGroupSessions).Include(x => x.LessonSubject);
            return await query.ToArrayAsync();
        }

        public async Task<LessonGroup> GetLessonGroup(int id)
        {
            return await _context.LessonGroups.Include(x => x.LessonControls).FirstOrDefaultAsync(x => x.Id == id);

        }
        public async Task<LessonSubject[]> GetLessonSubjects()
        {
            return await _context.LessonSubjects.ToArrayAsync();
        }
        //public async Task<MapNode[]> GetMaps()
        //{
        //    return await _context.Maps.ToArrayAsync();
        //}

        //public async Task<MapNode> GetMap(int id)
        //{
        //    return await _context.Maps.FirstOrDefaultAsync(x => x.Id == id);
        //}

        public async Task<School> GetSchool(int id)
        {
            return await _context.Schools.FirstOrDefaultAsync(x => x.Id == id);
        }
        //public async Task<List<QA>> GetQuestions(int subjectId)
        //{
        //    return await _context.QAs.Where(x => x.LessonSubjectId == subjectId).OrderBy(o => o.Question).ToListAsync();
        //}
        //public async Task<MapNode[]> GetMapsBySchoolId(int schoolId)
        //{
        //    // *** FIX THIS FOR NEW DB STRUCTURE ***
        //    return await _context.Maps.Where(x => x.SchoolId == schoolId).ToArrayAsync(); 
        //    return null;
        //}
        //public async Task<LessonSubject> GetLessonSubjectByName(string subject)
        //{
        //    return await _context.LessonSubjects.FirstOrDefaultAsync(x => x.Name == subject);
        //}

        public async Task<LessonSubject> GetLessonSubject(int id)
        {
            return await _context.LessonSubjects.FirstOrDefaultAsync(x => x.Id == id);
        }
        //public async Task<LessonGroup> AddLessonGroup(LessonGroup group)
        //{
        //    return await _context.LessonGroups.Add(group);
        //    _context.SaveChangesAsync();
        //}
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public async Task<bool> SaveChangesAsync()
        {
            _context.ChangeTracker.DetectChanges();
            var timestamp = DateTime.Now;
            foreach (var entry in _context.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                entry.Property("Modified").CurrentValue = timestamp;

                if (entry.State == EntityState.Added)
                {
                    entry.Property("Created").CurrentValue = timestamp;
                }
            }

            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        public Task<LessonGroup> AddLessonGroup(LessonGroup group)
        {
            throw new NotImplementedException();
        }

         public Task<QA> GetQA(int id)
        {
            return _context.QAs.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<QA[]> GetQAs()
        {
            return _context.QAs.ToArrayAsync();
        }

        public Task<LessonGroupSession[]> getGroupSessions(int id)
        {
            return _context.LessonGroupSessions.Where(x => x.LessonGroupId == id).ToArrayAsync();
        }
    }


}
