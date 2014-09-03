using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.Repositories
{
    public class EducationsRepository : IEducationsRepository
    {
        public IEnumerable<Education> GetEducations()
        {
            return new List<Education> {new Education {ID = 1, Description = "This is my first education", Name="Lakeville High School", Location = "Lakeville,MN", Type="High School", StartDate = new DateTime(2004, 9,2), EndDate = new DateTime(2008, 5, 1)}, 
                                        new Education {ID = 2, Description = "This is my second education", Name="Saint John's University", Location = "Collegeville, MN", Type="Bachelors Degree", StartDate = new DateTime(2008, 8, 21), EndDate = new DateTime(2012,5, 1)}};
        }
    }
}
