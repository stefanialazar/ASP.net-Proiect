using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSD233_DAW.Entities;
using LSD233_DAW.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace LSD233_DAW.Repositories.ActorRepository
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        Task<Actor> GetByFirstName(string name);
        Task<Actor> GetByLastName(string name);
        Task<List<Actor>> GetAllActorsWithRoles();
    }
}
