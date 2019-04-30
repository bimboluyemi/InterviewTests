using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.DataObjects
{
    public class Diploma
    {
        public int Id { get; set; }

        public int Credits { get; set; }

        public ICollection<Requirement> Requirements { get; set; }
    }
}
