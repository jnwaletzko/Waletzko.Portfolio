using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Waletzko.Portfolio.ServiceModel.Messages;
using Waletzko.Portfolio.Interfaces;

namespace Waletzko.Portfolio.ServiceDefinition
{
    public class ExperiencesService : Service
    {
        private readonly IExperiencesManager manager;

        public ExperiencesService(IExperiencesManager manager)
        {
            this.manager = manager;
        }

        public GetExperiencesResponse Get(GetExperiences request)
        {
            GetExperiencesResponse response = new GetExperiencesResponse();

            if (request.ID == 0)
            {
                response.Experiences = manager.GetExperiences();
            }
            else
            {
                response.Experiences = manager.GetExperiences(request.ID);
            }

            return response;
        }
    }
}
