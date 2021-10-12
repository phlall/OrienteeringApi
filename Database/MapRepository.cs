using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class MapRepository : RepositoryBase<Map>, IMapRepository
    {
        private readonly OrienteeringContext _context;
        public MapRepository(OrienteeringContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Map[]> GetMapsBySchoolId(int schoolId)
        {
            return await _context.Maps.Where(x => x.MapImage.SchoolId == schoolId).Include(i => i.MapImage).ToArrayAsync();
        }

        public async Task<Map[]> GetMaps()
        {
            return await _context.Maps.ToArrayAsync();
        }

        public async Task<Map> GetMap(int id)
        {
            return await _context.Maps.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> Save()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
