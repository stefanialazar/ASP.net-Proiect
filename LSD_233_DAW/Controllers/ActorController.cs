using LSD_233_DAW_DAL;
using LSD_233_DAW_DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSD_233_DAW.Controllers
{
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly ProiectContext _context;

        public ActorController(ProiectContext context)
        {
            _context = context;
        }

        [HttpPost("AddActor")]
        public async Task<IActionResult> AddActor([FromBody] Actor actor)
        {
            if(string.IsNullOrEmpty(actor.ActorFirstName))
            {
                return BadRequest("First name is NULL");
            }
            if (string.IsNullOrEmpty(actor.ActorLastName))
            {
                return BadRequest("Last name is NULL");
            }

            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetActor([FromRoute]int id)
        {
            var actor = await _context.Actors.Include(x => x.Role).Where(x => x.ActorId == id).ToListAsync();

            return Ok(actor);
        }
    }
}
