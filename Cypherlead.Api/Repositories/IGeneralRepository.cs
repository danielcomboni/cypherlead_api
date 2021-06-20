using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.Repositories
{
    public interface IGeneralRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Get entity by ID of type GUID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(Guid id);

        /// <summary>
        /// Create entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> CreateAsync(TEntity entity);

        /// <summary>
        /// Create entity
        /// </summary>
        /// <param name="entities"></param> 
        /// <returns></returns>
        Task<IEnumerable<TEntity>> CreateBatchAsync(IEnumerable<TEntity> entities);


        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity, Guid id);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(Guid id);

        /// <summary>
        /// Check if entity exists using unique GUID 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Exists(Guid id);

        IQueryable<TEntity> MakeOtherQuery(IQueryable<TEntity> queryable);
        IQueryable<TEntity> MakeConditionalQuery(IQueryable<TEntity> queryable);
        IQueryable<TEntity> MakeFullQuery(IQueryable<TEntity> queryable);


    }
}
