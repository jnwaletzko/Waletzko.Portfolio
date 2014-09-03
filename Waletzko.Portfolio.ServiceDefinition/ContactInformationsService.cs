using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.ServiceModel.Messages;

namespace Waletzko.Portfolio.ServiceDefinition
{
    public class ContactInformationsService : Service
    {
        private readonly IContactInformationsManager manager;

        public ContactInformationsService(IContactInformationsManager manager)
        {
            this.manager = manager;
        }

        public GetContactInformationsResponse Get(GetContactInformations request)
        {
            GetContactInformationsResponse response = new GetContactInformationsResponse();

            if (request.ID == 0)
            {
                response.ContactInformations = manager.GetContactInformations();
            }
            else
            {
                response.ContactInformations = manager.GetContactInformations(request.ID);
            }

            return response;
        }
    }
}
