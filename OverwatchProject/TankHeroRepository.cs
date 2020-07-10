using System;
using System.Collections.Generic;
using Atlas.Common.Persistence.Repositories;
using Atlas.Common.SharedKernel.Repositories;
using NHibernate;

namespace OverwatchProject
{
    public class TankHeroRepository : Repository<Hero>, ITankHeroRepository
    {
        public TankHeroRepository(ISession session) :base (session)
        {
        }
    }

    public interface ITankHeroRepository
    {
    }
}