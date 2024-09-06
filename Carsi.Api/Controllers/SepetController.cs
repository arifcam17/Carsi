using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Carsi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetController : ControllerBase
    {
        private readonly ISepetService _sepetService;
        private readonly IItemService _itemService;

        public SepetController(ISepetService sepetService, IItemService itemService)
        {
            _sepetService = sepetService;
            _itemService = itemService;
        }

        [HttpGet("getsepet/{userId}")]
        public async Task<IActionResult> CreateSepet(string  userId)
        {
            var response = await _sepetService.GetSepetByUserId(userId);
            return Ok(JsonSerializer.Serialize(response));
        }
        

        [HttpGet("initialize/{userId}")]
           public async Task<IActionResult> Initialize(string userId)
           {
            var response = await _sepetService.InitializeSepetAsync(userId);
            return Ok(JsonSerializer.Serialize(response) );
           }

          
          
           [HttpPost]

           public async Task<IActionResult> AddtoSepet(AddSepetDto addSepetDto)
           {
              var response = await _itemService.AddAsync(addSepetDto);
                 return Ok(JsonSerializer.Serialize(response)) ;
           }
            
            
            
            [HttpGet("deleteitem/{itemId}")]

           public async Task<IActionResult> DeleteItem(int itemId)
           {
              var response = await _itemService.DeleteItemAsync(itemId);
                 return Ok(JsonSerializer.Serialize(response)) ;
           }


        [HttpGet("clear/{userId}")]

        public async Task<IActionResult> ClearSepet(string userId)
        {
            var response = await _itemService.ClearAsync(userId);
            return Ok(JsonSerializer.Serialize(response));
        }




        [HttpPost("changequantity")]

        public async Task<IActionResult> ChangeQuantity(int sepetitemId , int quantity)
        {
            var response = await _itemService.ChangeQuantityAsync(sepetitemId, quantity);
            return Ok(JsonSerializer.Serialize(response));
        }
    }
}