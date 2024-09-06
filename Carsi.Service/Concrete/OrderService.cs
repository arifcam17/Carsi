using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Concrete
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepo;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepo, IMapper mapper)
        {
            _orderRepo = orderRepo;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> Create(OrderDto orderDto)
        {
            var order= _mapper.Map<Order>(orderDto);
            await _orderRepo.CreateAsync(order);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<List<OrderDto>>> GetAllOrders(string userId = null)
        {
            var orders = await _orderRepo.GetAllOrderAsync(userId);
            var ordersDto = _mapper.Map<List<OrderDto>>(orders);
            return Response<List<OrderDto>>.Success(ordersDto,200);
        }

        public async Task<Response<OrderDto>> GetOrder(int orderId)
        {
            var order = await _orderRepo.GetOrder(orderId);
            var ordersDto = _mapper.Map<OrderDto>(order);
            return Response<OrderDto>.Success(ordersDto, 200);
        }

       
    }
}