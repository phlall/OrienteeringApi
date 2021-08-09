using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class LessonGroupSessionRepository : RepositoryBase<LessonGroupSession>, ILessonGroupSessionRepository
    {
        private readonly OrienteeringContext _context;
        public LessonGroupSessionRepository(OrienteeringContext context) : base(context)
        {
            _context = context;
        }
    }
}
