using GraduationTracker.DataObjects;
using GraduationTracker.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Repository.Concrete
{
    public class RequirementRepository : IRequirementRepository
    {
        ICourseRepository _courseRepository;

        public RequirementRepository()
        {
            _courseRepository = new CourseRepository();
        }

        public Requirement Get(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
        
        public ICollection<Requirement> GetAll()
        {
            return new List<Requirement>
            {
                new Requirement{Id = 100, MinimumMark=50, CourseId = 1 },
                new Requirement{Id = 102, MinimumMark=50, CourseId = 2 },
                new Requirement{Id = 103, MinimumMark=50, CourseId = 3 },
                new Requirement{Id = 104, MinimumMark=50, CourseId = 4 }
            }; 
        }
    }
}
