using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.Managers
{
    public class PortfolioDetailsManager : IPortfolioDetailsManager  
    {
        public readonly IPortfolioDetailsRepository repository;

        public PortfolioDetailsManager(IPortfolioDetailsRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<PortfolioDetail> GetPortfolioDetails()
        {
            return repository.GetPortfolioDetails();
        }

        public IEnumerable<PortfolioDetail> GetPortfolioDetail(int ID)
        {
            return repository.GetPortfolioDetails().Where(p => p.ID == ID);
        }
    }
}
