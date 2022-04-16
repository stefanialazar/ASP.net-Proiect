using LSD_233_DAW_BLL.Interfaces;
using LSD_233_DAW_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LSD_233_DAW_BLL.Managers
{
    public class ActorManager : IActorManager
    {
        private readonly IActorRepository _actorRepo;
      
        public async Task<List<string>> ModifyActor()
        {
            var actors = await _actorRepo.GetAll();
            var list = new List<string>();

            foreach (var actor in actors)
            {
                list.Add($"ActorFirstName: {actor.ActorFirstName}, ActorLastName: {actor.ActorLastName}");
            }
            return list;
        }
    }
}
