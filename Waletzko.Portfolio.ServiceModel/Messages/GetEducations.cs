using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Waletzko.Portfolio.ServiceModel.Messages
{
    [Route("/Education", "GET")]
    [Route("/Education/{ID}", "GET")]
    public class GetEducations : IReturn <GetEducationsResponse>
    {
        public int ID { get; set; }
    }
}
