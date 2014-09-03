using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.ServiceModel.Types;
using Waletzko.Portfolio.Interfaces;

namespace Waletzko.Portfolio.Repositories
{
    public class PortfolioDetailsRepository : IPortfolioDetailsRepository
    {
        public IEnumerable<PortfolioDetail> GetPortfolioDetails()
        {
            return new List<PortfolioDetail> { new PortfolioDetail { ID = 1, Description = "This is the first in a list" }, new PortfolioDetail { ID = 2, Description = "This is the second in the list" } };
        }
    }
}
