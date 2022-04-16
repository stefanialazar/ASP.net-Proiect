using LSD_233_DAW_DAL.Entities;
using LSD_233_DAW_DAL.Helpers;
using LSD_233_DAW_DAL.Interfaces;
using LSD_233_DAW_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSD_233_DAW_DAL.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly ProiectContext _context;

        public ActorRepository(ProiectContext context)
        {
            _context = context;
        }

        public async Task Create(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Actor actor)
        {
            _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
        }

        public Task<List<ActorModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetById(int id)
        {
            var actor = await _context.Actors.FindAsync(id);
            return actor;
        }

        public async Task Update(Actor actor)
        {
            _context.Actors.Update(actor);
            await _context.SaveChangesAsync();
        }

        private async Task<IQueryable<Actor>> GetAllQuery()
        {
            var query = _context.Actors.AsQueryable();
            return query;
        }
    }
}
