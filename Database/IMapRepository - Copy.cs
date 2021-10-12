using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public interface IMapImageRepository : IRepositoryBase<MapImage>
    {
        Task<MapImage[]> GetBySchool(int schoolId);
    }
}