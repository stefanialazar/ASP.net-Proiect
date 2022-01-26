using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSD233_DAW.Data;
using LSD233_DAW.Entities;
using LSD233_DAW.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace LSD233_DAW.Repositories.ActorRepository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(ProiectContext context) : base(context) { }

        public async Task<List<Actor>> GetAllActorsWithRoles()
        {
            return await _context.Actors.Include(r => r.Role).ToListAsync();
        }

        public async Task<Actor> GetByFirstName(string name)
        {
            return await _context.Actors.Where(a => a.ActorFirstName.Equals(name)).FirstOrDefaultAsync();
        }

        public async Task<Actor> GetByLastName(string name)
        {
            return await _context.Actors.Where(a => a.ActorLastName.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
