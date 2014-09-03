using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.ServiceModel.Messages
{
    [Route("/ContactInformation", "GET")]
    [Route("/ContactInformation/{ID}", "GET")]
    public class GetContactInformations : IReturn<ContactInformation>
    {
        public int ID { get; set; }
    }
}
