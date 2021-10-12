using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public interface IMapRepository : IRepositoryBase<Map>
    {
        Task<Map[]> GetMapsBySchoolId(int schoolId);

        Task<Map[]> GetMaps();

        Task<Map> GetMap(int id);

        Task<bool> Save();
    }
}