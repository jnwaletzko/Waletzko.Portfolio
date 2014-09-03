using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.Managers
{
    public class EducationsManager : IEducationsManager
    {
        private readonly IEducationsRepository repository;

        public EducationsManager(IEducationsRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Education> GetEducations()
        {
            return repository.GetEducations();
        }

        public IEnumerable<Education> GetEducations(int id)
        {
            return repository.GetEducations().Where(e => e.ID == id);
        }
    }
}
