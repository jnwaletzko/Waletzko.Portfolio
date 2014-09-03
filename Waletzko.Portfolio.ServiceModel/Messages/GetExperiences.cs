using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Waletzko.Portfolio.ServiceModel.Messages
{
    [Route("/Experience", "GET")]
    [Route("/Experience/{ID}", "GET")]
    public class GetExperiences : IReturn<GetExperiencesResponse>
    {
        public int ID { get; set; }
    }
}
