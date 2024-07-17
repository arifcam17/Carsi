using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Carsi.Data.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
       protected readonly DbContext _dbContext;
       public GenericRepository(DbContext dbContext)
       {
         _dbContext=dbContext;
       }   


        public async Task<TEntity> CreateAsync(TEntity entity)
        {
           await _dbContext.Set<TEntity>().AddAsync(entity);
           await _dbContext.SaveChangesAsync();
           return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
             _dbContext.Set<TEntity>().Remove(entity);
             await _dbContext.SaveChangesAsync();    


        }

        public async Task<List<TEntity>> GetAllAsync()
        {
           List<TEntity> entities= await _dbContext.Set<TEntity>().ToListAsync();
           return entities;
        }

        public async Task<TEntity> GetById(int id)
        {
           TEntity entity= await _dbContext.Set<TEntity>().FindAsync(id);
           return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
           EntityEntry<TEntity> result=  _dbContext.Set<TEntity>().Update(entity);
           await _dbContext.SaveChangesAsync();
           return entity;  
        }
    }
}