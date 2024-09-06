using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Concrete;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Abstract
{
    public interface IOrderService
    {
        Task<Response<NoContent>> Create (OrderDto orderDto);
        Task<Response<OrderDto>> GetOrder(int orderId);
        Task<Response<List<OrderDto>>> GetAllOrders (string userId=null);
    }
}