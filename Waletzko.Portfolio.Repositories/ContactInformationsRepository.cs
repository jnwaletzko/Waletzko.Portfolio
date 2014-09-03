using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.ServiceModel.Types;
using Waletzko.Portfolio.Interfaces;

namespace Waletzko.Portfolio.Repositories
{
    public class ContactInformationsRepository : IContactInformationsRepository
    {
        public IEnumerable<ContactInformation> GetContactInformations()
        {
            return new List<ContactInformation> {new ContactInformation { ID = 1, Name="Email", Value="jnwaletzko@gmail.com"},
                                                 new ContactInformation { ID = 2, Name="Phone", Value="952-220-7267"}};
        }
    }
}
