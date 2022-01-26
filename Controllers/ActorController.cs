using LSD233_DAW.Entities;
using LSD233_DAW.Entities.DTOs;
using LSD233_DAW.Repositories.ActorRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSD233_DAW.Controllers
{
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorRepository _repository;

        public ActorController(IActorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllActors()
        {
            var actors = await _repository.GetAllActorsWithRoles();

            var actorsToReturn = new List<ActorDTO>();

            foreach(var actor in actors)
            {
                actorsToReturn.Add(new ActorDTO(actor));
            }

            return Ok(actorsToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActor(CreateActorDTO actorDTO)
        {
            Actor newActor = new Actor();
            
            newActor.Role = actorDTO.Role;
            newActor.ActorFirstName = actorDTO.ActorFirstName;
            newActor.ActorLastName = actorDTO.ActorLastName;

            _repository.Create(newActor);

            await _repository.SaveAsync();

            return Ok(new ActorDTO(newActor));
            
        }
    }
}
