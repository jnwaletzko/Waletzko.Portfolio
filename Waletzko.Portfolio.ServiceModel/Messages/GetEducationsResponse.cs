using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.ServiceModel.Messages
{
    public class GetEducationsResponse : IHasResponseStatus
    {
        public IEnumerable<Education> Educations { get; set; }

        public ResponseStatus ResponseStatus { get; set; }

    }
}
