using System.Collections.Generic;

namespace OverwatchProject
{
    public class TankHeroAdto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<TankHeroAdto> TankHeroes { get; set; }
    }
}