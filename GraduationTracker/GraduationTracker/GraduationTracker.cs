using GraduationTracker.DataObjects;
using GraduationTracker.Enums;
using GraduationTracker.Repository.Abstract;
using GraduationTracker.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public partial class GraduationTracker : IGraduationTracker
    {
        
        private readonly ICourseRepository _courseRepository;

        public GraduationTracker()
        {
            _courseRepository = new CourseRepository();
        }

        public Tuple<bool, STANDING, int> HasGraduated(Diploma diploma, Student student)
        {
            var credits = 0;
            var average = 0;

            average = GetStudentAverage(student, diploma.Requirements, out credits);

            var standing = GetStandingByAverage(average);

            var graduated = (standing == STANDING.Average || standing == STANDING.SumaCumLaude || standing == STANDING.MagnaCumLaude) ? true : false;
            
            return new Tuple<bool, STANDING, int>(graduated, standing, credits);

        }

        private int GetStudentAverage(Student student, ICollection<Requirement> requirements, out int credit)
        {
            var average = 0;
            var credits = 0;

            foreach (var requirement in requirements)
            {
                var studentGrade = student.Grades.FirstOrDefault(x => x.CourseId == requirement.CourseId);
                if (studentGrade != null)
                {
                    average += studentGrade.Mark;
                    if (studentGrade.Mark > requirement.MinimumMark)
                    {
                        var course = _courseRepository.Get(requirement.CourseId);
                        credits += course.Credits;

                    }
                }
            }
            credit = credits;
            return average / requirements.Count;
        }

        private STANDING GetStandingByAverage(int average)
        {
            var standing = STANDING.None;

            if (average < 50)
                standing = STANDING.Remedial;
            else if (average < 80)
                standing = STANDING.Average;
            else if (average < 95)
                standing = STANDING.MagnaCumLaude;
            else
                standing = STANDING.MagnaCumLaude;

            return standing;
        }
    }
}
