using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace docker_netcore_web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var rng = new Random();
            var max = rng.Next(15) + 1;
            for (var i = 0; i < max; i++)
            {
                yield return $"Hello world {i}";
            }
        }
    }
}