using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Concrete;

namespace Carsi.Data.Abstract
{
    public interface IUserRepository:IGenericRepository<User>
    {
        Task<User> CheckPassword(string password, string email);
        Task<User> CheckNameAsync(string name, User user);

          Task<User> GetPasswordByUserId(int userId);
    }
}