using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.ServiceModel.Types;
using Waletzko.Portfolio.Interfaces;

namespace Waletzko.Portfolio.Repositories
{
    public class ExperiencesRepository : IExperiencesRepository
    {
        public IEnumerable<Experience> GetExperiences()
        {
            return new List<Experience> {new Experience { ID = 1, Description="This is my first experience", Name="Computer Science Teaching Assistant", Location="Saint John's Collegeville, MN", StartDate=new DateTime(2010, 1,1), EndDate = new DateTime(2012, 5,1)},
                             new Experience { ID = 2, Description="This is my second experience", Name="Programmer Analyst 1", Location = "C.H. Robinson Eden Prairie, MN", StartDate = new DateTime(2012, 6, 1), EndDate = DateTime.Now}};
        }
    }
}
