using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSD233_DAW.Controllers
{
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static readonly List<string> Filme = new List<string>
        {
            "A", "B", "C", "C", "Mild", "Warm", "Balmy", "Hot"
        };

        private static readonly List<string> Actori = new List<string>
        {
            "A LEl", "B Lol", "C No", "C w", "Mild yes"
        };

        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Movies")]
        public IActionResult GetFilme()
        {
            string actori_in_filme = Filme[0] + " " + Actori[0];
            return Ok(actori_in_filme);

        }

    }
}
