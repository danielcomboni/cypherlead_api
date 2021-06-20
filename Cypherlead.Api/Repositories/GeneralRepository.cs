using Cypherlead.Api.Core.Extensions;
using Cypherlead.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.Repositories
{
    public class GeneralRepository<TEntity> : IGeneralRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> entity = null;
        private readonly ILogger<TEntity> _logger;
        private readonly string entityNameToLog = typeof(TEntity).Name.ToString();
        private TEntity entityFound;

        public GeneralRepository(ApplicationDbContext context, ILogger<TEntity> logger)
        {
            _context = context;
            entity = _context.Set<TEntity>();
            _logger = logger;
        }

        private static TEntity DefaultTEntity()
        {
            TEntity t = default(TEntity);
            return t;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            _logger.StartNew();
            _logger.CreateNewEntityMessage(entityNameToLog);
            await _context.AddAsync(entity);
            var result = await _context.SaveChangesAsync();
            // this will give the ID obtained/returned after creation/insertion
            var id = entity.GetType().GetProperty("Id").GetValue(entity);
            var createdEntity = DefaultTEntity();

            if (result > 0)
            {
                createdEntity = entity;
                _logger.CreatedNewEntityMessage(entityNameToLog, id);
            }

            return createdEntity;
        }
        public async Task<IEnumerable<TEntity>> CreateBatchAsync(IEnumerable<TEntity> entities)
        {
            _logger.StartNew();
            var batch = entities as IList<TEntity> ?? entities.ToList();

            try
            {
                _logger.CreatingABatch(entityNameToLog);
                await _context.AddRangeAsync(batch);
                await _context.SaveChangesAsync();
                return batch;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }
        public virtual async Task<int> DeleteAsync(Guid id)
        {
            _logger.StartNew();
            var deletedRows = 0;
            if (!await Exists(id))
            {
                return deletedRows;
            }

            _logger.DeletingAnEntityRecord(entityNameToLog, id);
            _context.Remove(entityFound);
            deletedRows = await _context.SaveChangesAsync();
            if (deletedRows > 0)
                _logger.Deleted(entityNameToLog, id);
            return deletedRows;
        }

        public async Task<bool> Exists(Guid id)
        {
            _logger.CheckExistence(entityNameToLog, id);
            var found = await entity.FindAsync(id);

            if (found == null)
            {
                _logger.NotFoundWithId(entityNameToLog, id);
                return false;
            }
            _logger.FoundToExist(entityNameToLog, id);
            entityFound = found;
            return true;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            _logger.StartNew();
            _logger.RetrievingAll(entityNameToLog);
            return await entity.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            _logger.StartNew();
            if (!await Exists(id))
            {
                return null;
            }

            _logger.RetrievingOneById(entityNameToLog, id);

            return await entity.FindAsync(id);
        }

        public IQueryable<TEntity> MakeConditionalQuery(IQueryable<TEntity> queryable)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> MakeFullQuery(IQueryable<TEntity> queryable)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> MakeOtherQuery(IQueryable<TEntity> queryable)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, Guid id)
        {
            _logger.StartNew();
            var exists = await Exists(id);
            this.entity.Local.Clear();
            //Console.WriteLine($"tracked:{this.entity.Local}");

            if (Equals(!exists))
            {
                return null;
            }
            _logger.Updating(entityNameToLog, id);
            //this.entity.Attach(entity);
            _context.Entry(entity).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            _logger.Updated(entityNameToLog, id);
            return entity;
        }


    }
}
