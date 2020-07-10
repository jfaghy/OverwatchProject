using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OverwatchProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OverwatchController : ControllerBase
    {
        private static readonly string[] Heroes = new[]
        {
            "Reinhardt", "Genji", "Ana", "Zarya", "Tracer", "Mercy"
        };

        private readonly ILogger<OverwatchController> _logger;

        public OverwatchController(ILogger<OverwatchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Overwatch> Get()
        {
            var rng = new Random(); 
            return Enumerable.Range(1, 5).Select(index => new Overwatch
            {
                Date = DateTime.Now.AddDays(index),
                Damage = rng.Next(-20, 55),
                Health = rng.Next(-20, 55),
                Hero = Heroes[rng.Next(Heroes.Length)],
                Id = index
            })
            .ToArray();
        }
    }
}
