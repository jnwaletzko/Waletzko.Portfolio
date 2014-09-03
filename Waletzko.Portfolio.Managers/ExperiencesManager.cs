using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.Managers
{
    public class ExperiencesManager : IExperiencesManager
    {
        public readonly IExperiencesRepository repository;

        public ExperiencesManager(IExperiencesRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Experience> GetExperiences()
        {
            return repository.GetExperiences();
        }

        public IEnumerable<Experience> GetExperiences(int id)
        {
            return repository.GetExperiences().Where(e => e.ID == id);
        }
    }
}
