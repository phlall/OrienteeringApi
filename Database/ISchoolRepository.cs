using System;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public interface ISchoolRepository : IRepositoryBase<School>
    {
        // Task<School[]> GetLessonGroupsBySchoolId(int schoolId);
        Task<Pupil[]> GetPupils(int schoolId);
    }
}