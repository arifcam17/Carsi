using Carsi.Shared.DTOS;
using Carsi.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Service.Abstract
{
    public interface IItemService
    {
       Task<Response<NoContent>> AddAsync(SepetDto add);
        Task<Response<NoContent>> ClearAsync(int userId);
        Task<Response<NoContent>> DeleteItemAsync(int itemId);
        Task<Response<NoContent>> ChangeQuantityAsync(int itemId, int quantity);
    }
}