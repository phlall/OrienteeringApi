using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Database
{
    public interface ILessonGroupRepository : IRepositoryBase<LessonGroup>
    {
        Task<LessonGroup[]> GetLessonGroupsBySchoolId(int schoolId);
        Task<LessonGroup> GetLessonGroupFull(int id);
    }
}
