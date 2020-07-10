using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace OverwatchProject
{
    [ApiController]
    [Route("[controller]")]
    public class TankHeroesController : Controller
    {
        private Hero[] heroes = {
            new Hero(1, "Roadhog", 600, 150),
            new Hero(2, "Reinhardt", 500, 75),
            new Hero(3, "D.Va", 500, 50),
            new Hero(4, "Zarya", 400, 100),
            new Hero(5, "Winston", 500, 40)
        };

        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return heroes;
        }

        [HttpGet]
        [Route("{heroId:int}")]
        public ActionResult Get(int heroId)
        {
            Hero hero = heroes.FirstOrDefault(p => p.HeroId == heroId);
            if (hero == null)
            {
                return BadRequest();
            }
            return Ok(hero);
        }
    }
}