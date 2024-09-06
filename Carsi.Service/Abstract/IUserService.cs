using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Concrete;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Abstract
{
    public interface IUserService
    {
        Task<Response<bool>> CheckUserPassword(string password, string email);
        Task<Response<UserDto>> CheckUserName(string userName , UserDto userDto);



        
        Task<Response<UserDto>> CreateUserAsync(UserDto userDto);
        
        Task<Response<UserDto>> UpdateUserAsync(UserDto userDto);



         
       Task<Response<List<UserDto>>> GetallUserAsync();


        Task<Response<UserDto>> GetUserById(int id);
        Task<Response<UserDto>> DeleteUserAsync(int id);
    }
}