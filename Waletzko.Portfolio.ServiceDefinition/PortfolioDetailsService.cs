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
    public class PortfolioDetailsService : Service
    {
        public readonly IPortfolioDetailsManager manager;

        public PortfolioDetailsService(IPortfolioDetailsManager manager)
        {
            this.manager = manager;
        }

        public GetPortfolioDetailsResponse Get(GetPortfolioDetails request)
        {
            GetPortfolioDetailsResponse response = new GetPortfolioDetailsResponse();

            if (request.ID == 0)
            {
                response.PortfolioDetails = manager.GetPortfolioDetails();
            }
            else
            {
                response.PortfolioDetails = manager.GetPortfolioDetail(request.ID);
            }

            return response;
        }
    }
}
