using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSD233_DAW.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity>
    {
        // Get Data

        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);

        // Create
        void Create(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
    
        // Update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        // Delete
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        // Save
        Task<bool> SaveAsync();

    }
}
