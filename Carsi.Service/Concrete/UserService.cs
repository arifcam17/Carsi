using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Internal;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Carsi.Service.Abstract;
using Carsi.Shared.DTOS;
using Carsi.Shared.Response;

namespace Carsi.Service.Concrete
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task<Response<UserDto>> CheckUserName(string userName, UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var userinfo = await _userRepository.CheckNameAsync(userName, user);
            if (user.Name == userName)
            {
                return Response<UserDto>.Success(userDto, 200);
            }
            return Response<UserDto>.Failure("isim hatali", 404);
        }

        public async Task<Response<bool>> CheckUserPassword(string password, string email)
        {



            var userpass = await _userRepository.CheckPassword(password, email);
           
            if (userpass == null)
            {
                return Response<bool>.Failure("sifre veya kullanici adi hatali tekrar deneyin", 404);

            }
            return Response<bool>.Success(userpass != null, 200);

        }

        public async Task<Response<UserDto>> CreateUserAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var createdUser = await _userRepository.CreateAsync(user);
            if (createdUser == null)
            {
                return Response<UserDto>.Failure("kullanici eklenemedi", 404);
            }
            var createdUserDto = _mapper.Map<UserDto>(createdUser);
            return Response<UserDto>.Success(createdUserDto, 200);

        }

        public async Task<Response<UserDto>> DeleteUserAsync(int id)
        {

            var user = await _userRepository.GetById(id);
            var deleteduser = _userRepository.DeleteAsync(user);
            if (user == null)
            {
                return Response<UserDto>.Failure("kullanici bulunamadi", 404);
            }
            var deleteduserdto = _mapper.Map<UserDto>(deleteduser);
            return Response<UserDto>.Success(deleteduserdto, 200);
        }

        public async Task<Response<UserDto>> GetUserById(int id)
        {
            var user = await _userRepository.GetById(id);
            var userdto = _mapper.Map<UserDto>(user);
            if (user == null)
            {
                return Response<UserDto>.Failure("", 404);
            }
            return Response<UserDto>.Success(userdto, 200);
        }

        public async Task<Response<UserDto>> UpdateUserAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var updateduser = await _userRepository.UpdateAsync(user);
            //if
            var updateduserdto = _mapper.Map<UserDto>(updateduser);
            return Response<UserDto>.Success(updateduserdto, 200);



        }
    }
}