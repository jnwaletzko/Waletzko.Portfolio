using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Waletzko.Portfolio.ServiceModel.Messages
{
    [Route("/PortfolioDetail", "GET")]
    [Route("/PortfolioDetail/{ID}", "GET")]
    public class GetPortfolioDetails : IReturn<GetPortfolioDetailsResponse>
    {
        public int ID { get; set; }
    }
}
