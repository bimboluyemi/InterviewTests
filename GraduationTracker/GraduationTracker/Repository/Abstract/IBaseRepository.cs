using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Repository.Abstract
{
    public interface IBaseRepository<T, Tk> where T : class
    {
        T Get(Tk id);
    }
}
