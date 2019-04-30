using GraduationTracker.DataObjects;
using GraduationTracker.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Repository.Concrete
{
    public class DiplomaRepository : IDiplomaRepository
    {
        IRequirementRepository _requirementRepository;

        public DiplomaRepository()
        {
            _requirementRepository = new RequirementRepository();
        }

        public Diploma Get(int id)
        {
            var diplomas = GetAll();
            var diploma = diplomas.FirstOrDefault(x => x.Id == id);
            return diploma;
        }
        
        public ICollection<Diploma> GetAll()
        {
            return new List<Diploma>
            {
                new Diploma { Id = 1, Credits = 4, Requirements = _requirementRepository.GetAll() }
            };
        }
    }
}
