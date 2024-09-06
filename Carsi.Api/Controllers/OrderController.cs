using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Carsi.Shared.HELPERS.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Carsi.Api.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;
        private readonly IImageHelper _imageHelper;

        public OrderController(IOrderService orderService , IImageHelper imageHelper)
        {
            _orderService=orderService;
            _imageHelper=imageHelper;
        }

        [HttpPost]
        public async Task<IActionResult> NewOrder(OrderDto orderDto)
        {

           var response = await _orderService.Create(orderDto);

            return Ok(JsonSerializer.Serialize(response));
        }

         [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrder(int orderId)
        {

           var response = await _orderService.GetOrder(orderId);

            return Ok(JsonSerializer.Serialize(response));
        }


        [HttpGet("getall/{userId?}")]
        public async Task<IActionResult> GetOrder(string userId=null)
        {

           var response = await _orderService.GetAllOrders(userId); 

            return Ok(JsonSerializer.Serialize(response));
        }

        
    }
}