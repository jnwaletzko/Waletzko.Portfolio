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
    public class EducationsService : Service
    {
        public readonly IEducationsManager manager;

        public EducationsService(IEducationsManager manager)
        {
            this.manager = manager;
        }

        public GetEducationsResponse Get(GetEducations request)
        {
            GetEducationsResponse response = new GetEducationsResponse();

            if (request.ID == 0)
            {
                response.Educations = manager.GetEducations();
            }
            else
            {
                response.Educations = manager.GetEducations(request.ID);
            }

            return response;
        }
    }
}
