using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.Interfaces;
using Waletzko.Portfolio.ServiceModel.Types;

namespace Waletzko.Portfolio.Managers
{
    public class SkillsManager : ISkillsManager
    {
        public readonly ISkillsRepository repository;

        public SkillsManager(ISkillsRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Skill> GetSkills()
        {
            return repository.GetSkills();
        }

        public IEnumerable<Skill> GetSkills(int id)
        {
            return repository.GetSkills().Where(s => s.ID == id);
        }
    }
}
