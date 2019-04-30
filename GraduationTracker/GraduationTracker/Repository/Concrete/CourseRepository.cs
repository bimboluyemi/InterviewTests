using GraduationTracker.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationTracker.DataObjects;

namespace GraduationTracker.Repository.Concrete
{
    public class CourseRepository : ICourseRepository
    {
        public Course Get(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public ICollection<Course> GetAll()
        {
            return new List<Course>
            {
                new Course{Id = 1, Name = "Math", Credits = 1 },
                new Course{Id = 2, Name = "Science", Credits = 1 },
                new Course{Id = 3, Name = "Literature", Credits = 1 },
                new Course{Id = 4, Name = "Physichal Education", Credits = 1 }
            };
        }
    }
}
