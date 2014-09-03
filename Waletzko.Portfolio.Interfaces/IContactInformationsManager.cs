﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.Interfaces
{
    public interface IContactInformationsManager
    {
        IEnumerable<ContactInformation> GetContactInformations();

        IEnumerable<ContactInformation> GetContactInformations(int id);
    }
}
