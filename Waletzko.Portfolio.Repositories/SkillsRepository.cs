using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waletzko.Portfolio.ServiceModel.Types;
using Waletzko.Portfolio.Interfaces;

namespace Waletzko.Portfolio.Repositories
{
    public class SkillsRepository : ISkillsRepository
    {
        public IEnumerable<Skill> GetSkills()
        {
            return new List<Skill> {new Skill {ID = 1, Description = "This is my first skill", Name = "Java", Level = 5},
                                    new Skill {ID = 2, Description = "This is my second skill", Name = "C#", Level = 7}};
        }
    }
}
