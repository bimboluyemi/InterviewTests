using GraduationTracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.DataObjects
{
    public class Student
    {
        public int Id { get; set; }
        public Course[] Courses { get; set; }
        public STANDING Standing { get; set; } = STANDING.None;
    }
}
