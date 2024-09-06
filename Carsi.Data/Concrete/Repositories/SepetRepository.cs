using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Carsi.Data.Concrete.Repositories
{
    public class SepetRepository : GenericRepository<Sepet>, ISepetRepository
    {
        public SepetRepository(CarsiDbContext dbContext) : base(dbContext)
        {
        }
        
         private CarsiDbContext CarsiDbContext 
        {
            get{ return _dbContext as CarsiDbContext; }
        }

        public Task<Sepet> GetCartByUserIdAsync(string userId)
        {

            var sepet=
            CarsiDbContext
            .Sepets
            .Where(s => s.UserId == userId)
            .Include(i => i.Items)
            .ThenInclude(p=>p.Product)
            .FirstOrDefaultAsync();

            return sepet;

        }
    }
}