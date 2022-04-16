using LSD_233_DAW_DAL.Entities;
using LSD_233_DAW_DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LSD_233_DAW_DAL.Interfaces
{ 
    public interface IActorRepository
    {
        Task<List<ActorModel>> GetAll();
        Task<Actor> GetById(int id);
        Task Create(Actor actor);
        Task Update(Actor actor);
        Task Delete(Actor actor);

    }
}
