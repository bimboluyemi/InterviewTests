using GraduationTracker.DataObjects;
using GraduationTracker.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Repository.Concrete
{
    public class StudentRepository : IStudentRepository
    {

        public Student Get(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
        
        public ICollection<Student> GetAll()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1, 
                    Grades = new List<StudentGrade>
                    {
                        new StudentGrade { CourseId = 1, Mark = 95 },
                        new StudentGrade { CourseId = 2, Mark = 95 },
                        new StudentGrade { CourseId = 3, Mark = 95 },
                        new StudentGrade { CourseId = 4, Mark = 95 },
                    }
                },
                new Student
                {
                    Id = 2,
                    Grades = new List<StudentGrade>
                    {
                        new StudentGrade { CourseId = 1, Mark = 80 },
                        new StudentGrade { CourseId = 2, Mark = 80 },
                        new StudentGrade { CourseId = 3, Mark = 80 },
                        new StudentGrade { CourseId = 4, Mark = 80 },
                    }
                },
                new Student
                {
                    Id = 3,
                    Grades = new List<StudentGrade>
                    {
                        new StudentGrade { CourseId = 1, Mark = 50 },
                        new StudentGrade { CourseId = 2, Mark = 50 },
                        new StudentGrade { CourseId = 3, Mark = 50 },
                        new StudentGrade { CourseId = 4, Mark = 50 },
                    }
                },
                new Student
                {
                    Id = 4,
                    Grades = new List<StudentGrade>
                    {
                        new StudentGrade { CourseId = 1, Mark = 40 },
                        new StudentGrade { CourseId = 2, Mark = 40 },
                        new StudentGrade { CourseId = 3, Mark = 40 },
                        new StudentGrade { CourseId = 4, Mark = 40 },
                    }
                },
            };
        }
    }
}
