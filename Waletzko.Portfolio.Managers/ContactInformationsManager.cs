using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.Managers
{
    public class ContactInformationsManager : IContactInformationsManager
    {
        private readonly IContactInformationsRepository repository;

        public ContactInformationsManager(IContactInformationsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<ContactInformation> GetContactInformations()
        {
            return repository.GetContactInformations();
        }

        public IEnumerable<ContactInformation> GetContactInformations(int id)
        {
            return repository.GetContactInformations().Where(c => c.ID == id);
        }
    }
}
