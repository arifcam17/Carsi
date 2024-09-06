using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Concrete.Repositories;
using Carsi.Entity.Concrete;

namespace Carsi.Data.Abstract
{
    public interface IItemRepository:IGenericRepository<Item>
    {
        
    }
}