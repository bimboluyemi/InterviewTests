using GraduationTracker.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Repository.Abstract
{
    public interface ICourseRepository : IBaseRepository<Course, int>
    {
    }
}
