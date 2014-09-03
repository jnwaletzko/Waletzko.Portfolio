using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using Waletzko.Portfolio.ServiceDefinition;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.Managers;
using Waletzko.Portfolio.Repositories;

namespace Waletzko.Portfolio.API
{
    public class WaletzkoPortfolioAPIAppHost : AppHostBase
    {
        public WaletzkoPortfolioAPIAppHost() : base("WaletzkoPortfolioAPI", typeof(ServiceDefinitionInfo).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            this.InitializeContainer(container);
            this.InitializePlugins();
        }

        private void InitializeContainer(Funq.Container container)
        {
            container.RegisterAutoWiredAs<PortfolioDetailsRepository, IPortfolioDetailsRepository>();
            container.RegisterAutoWiredAs<PortfolioDetailsManager, IPortfolioDetailsManager>();
            container.RegisterAutoWiredAs<EducationsRepository, IEducationsRepository>();
            container.RegisterAutoWiredAs<EducationsManager, IEducationsManager>();
            container.RegisterAutoWiredAs<ExperiencesRepository, IExperiencesRepository>();
            container.RegisterAutoWiredAs<ExperiencesManager, IExperiencesManager>();
            container.RegisterAutoWiredAs<SkillsRepository, ISkillsRepository>();
            container.RegisterAutoWiredAs<SkillsManager, ISkillsManager>();
            container.RegisterAutoWiredAs<ContactInformationsRepository, IContactInformationsRepository>();
            container.RegisterAutoWiredAs<ContactInformationsManager, IContactInformationsManager>();
        }

        private void InitializePlugins()
        {
        }
    }
}