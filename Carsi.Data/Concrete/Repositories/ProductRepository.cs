using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Carsi.Data.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(CarsiDbContext dbContext) : base(dbContext)
        {
            
        }

        private CarsiDbContext CarsiDbContext 
        {
            get{ return _dbContext as CarsiDbContext; }
        }
              //burada isActive vermesek ve true yapsak da olur muydu
        public Task<List<Product>> GetActiveProductsAsync(bool IsActive)
        {
            var activeProducts=
             CarsiDbContext
             .Products
             .Where(p =>p.IsActive==IsActive)  
             .ToListAsync();
             return  activeProducts;

        }

        public Task<List<Product>> GetHomeProducts()
        {
            var products =     
            CarsiDbContext.Products
            .Where(p =>p.IsHome==true)
            .ToListAsync();
            return products;
        }
    }
}