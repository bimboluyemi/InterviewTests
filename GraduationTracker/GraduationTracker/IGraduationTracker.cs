using GraduationTracker.DataObjects;
using GraduationTracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public interface IGraduationTracker
    {
        Tuple<bool, STANDING, int> HasGraduated(Diploma diploma, Student student);
    }
}
