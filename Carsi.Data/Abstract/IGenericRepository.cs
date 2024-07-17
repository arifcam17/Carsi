using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
                
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<TEntity> GetById(int id);
    }
}