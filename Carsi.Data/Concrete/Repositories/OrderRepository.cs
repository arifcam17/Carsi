using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Carsi.Data.Concrete.Repositories
{
    public class OrderRepository: GenericRepository<Order> ,IOrderRepository
    {
         public OrderRepository(CarsiDbContext dbContext) : base(dbContext)
        {
        }
        private CarsiDbContext CarsiDbContext 
        {
            get{ return _dbContext as CarsiDbContext; }
        }

        public async Task<List<Order>> GetAllOrderAsync(string userId = null)
        {
           if (userId == null)
           {
            return await CarsiDbContext
               .Orders
               .Include(o => o.OrderItems)
               .ThenInclude(o => o.Product)
               .ToListAsync();
           }
           
           
            return await CarsiDbContext
            .Orders
            .Where(o=>o.UserId == userId)
            .Include(o => o.OrderItems)
            .ThenInclude(o => o.Product)
            .ToListAsync();


        }

        public async Task<Order> GetOrder(int orderId)
        {
            return await CarsiDbContext
            .Orders
            .Where(x=>x.Id==orderId)
            .Include(x=>x.OrderItems)
            .ThenInclude(y=>y.Product)
            .FirstOrDefaultAsync();
            
        }

        
        }
    }
}