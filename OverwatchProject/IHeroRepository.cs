using System.Collections.Generic;
using Atlas.Common.SharedKernel.Repositories;

namespace OverwatchProject
{
    public interface IHeroRepository : IRepository<Hero>
    {
        IEnumerable<Hero> GetAll();
    }
}