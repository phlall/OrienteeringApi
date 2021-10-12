using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public class MapImageRepository : RepositoryBase<MapImage>, IMapImageRepository
    {
        private readonly OrienteeringContext _context;
        public MapImageRepository(OrienteeringContext context) : base(context)
        {
            _context = context;
        }
        public async Task<MapImage[]> GetBySchool(int schoolId)
        {
            return await _context.MapImages.Where(x => x.SchoolId == schoolId).ToArrayAsync();
        }

        //public async Task<MapImage[]> GetMaps()
        //{
        //    return await _context.MapImages.ToArrayAsync();
        //}

        //public async Task<MapImage> GetMap(int id)
        //{
        //    return await _context.MapImages.FirstOrDefaultAsync(x => x.Id == id);
        //}
    }
}
