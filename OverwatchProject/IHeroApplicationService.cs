using System.Collections.Generic;

namespace OverwatchProject
{
    public interface IHeroApplicationService
    {
        IEnumerable<TankHeroAdto> GetAll();

        void FillTankHeroRepository();
    }
}