using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Concrete;

namespace Carsi.Data.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetActiveProductsAsync(bool IsActive);
        Task<List<Product>> GetHomeProducts();
    }
}