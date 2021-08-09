using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class SubjectRepository : RepositoryBase<LessonSubject>, ISubjectRepository
    {
        private readonly OrienteeringContext _context;
        public SubjectRepository(OrienteeringContext context) : base(context)
        {
            _context = context;
        }
    }
}
