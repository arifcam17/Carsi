using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Carsi.Data.Concrete.Repositories
{
    public class ItemRepository : GenericRepository<Item> ,IItemRepository
    {
        public ItemRepository(CarsiDbContext dbContext) : base(dbContext)
        {
        }
        private CarsiDbContext CarsiDbContext 
        {
            get{ return _dbContext as CarsiDbContext; }
        }
    }
}