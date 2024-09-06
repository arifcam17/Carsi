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
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var resposne= await _userService.GetallUserAsync();
             if (resposne == null) 
            {
                return NotFound(JsonSerializer.Serialize(resposne));
            }
             return Ok(JsonSerializer.Serialize(resposne));
        }

        [HttpGet("password")]
        public async Task<IActionResult> CheckPassword(string password, string email)
        {
            var response = await _userService.CheckUserPassword(password,email);

            if (response == null) {
                return NotFound(JsonSerializer.Serialize(response));
            }
            return Ok(JsonSerializer.Serialize(response));

            
        }

        [HttpGet("name")]
        public async Task<IActionResult> CheckName(string name, UserDto userDto)
        {
            var response = await _userService.CheckUserName(name, userDto);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto userDto)
        {
            var response = await _userService.CreateUserAsync(userDto);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var response = await _userService.GetUserById(id);
            if (response == null) { return NotFound(); }
            return Ok(response);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateUser(UserDto editUserDto)

        {
            var response = await _userService.UpdateUserAsync(editUserDto);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response = await _userService.DeleteUserAsync(id);
            return Ok(response);
        }
    
    }

}