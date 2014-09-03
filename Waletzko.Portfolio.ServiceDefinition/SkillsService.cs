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
    public class SkillsService : Service
    {
        private readonly ISkillsManager manager;

        public SkillsService(ISkillsManager manager)
        {
            this.manager = manager;
        }

        public GetSkillsResponse Get(GetSkills request)
        {
            GetSkillsResponse response = new GetSkillsResponse();

            if (request.ID == 0)
            {
                response.Skills = manager.GetSkills();
            }
            else
            {
                response.Skills = manager.GetSkills(request.ID);
            }

            return response;
        }
    }
}
