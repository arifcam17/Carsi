using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Concrete;

namespace Carsi.Data.Abstract
{
    public interface ISepetRepository: IGenericRepository<Sepet>
    {
        Task<Sepet> GetCartByUserIdAsync(int userId);
    }
}