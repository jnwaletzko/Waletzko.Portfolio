using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.ServiceModel.Messages
{
    [Route("/Skill", "GET")]
    [Route("/Skill/{ID}", "GET")]
    public class GetSkills : IReturn<GetSkillsResponse>
    {
        public int ID { get; set; }
    }
}
