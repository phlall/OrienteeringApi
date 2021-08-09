using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class PupilRepository : RepositoryBase<Pupil>, IPupilRepository
    {
        private readonly OrienteeringContext _context;
        public PupilRepository(OrienteeringContext context) : base(context)
        {
            _context = context;
        }
    }
}
