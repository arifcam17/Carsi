using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Abstract;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Carsi.Data.Concrete.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CarsiDbContext dbContext) : base(dbContext)
        {
        }
        private CarsiDbContext CarsiDbContext
        {
            get{ return _dbContext as CarsiDbContext; }
        }

        public Task<User> CheckNameAsync(string name, User user)
        {

            if (name == user.Name)
            {  return
               CarsiDbContext
              .Users
              .Where(u => u.Name == name)
              .FirstOrDefaultAsync();
            }
            return null;
              
        }

        public async Task<User> CheckPassword(string password , string email )
        {  

            

              var user=
              await CarsiDbContext
              .Users
              .Where(u => u.Password == password &&  u.Email==email)
              
              .FirstOrDefaultAsync();
           
                return user;
            
        }

        public async Task<User> GetPasswordByUserId(int userId)
        {
           var  user= await CarsiDbContext.Users
            .Where(u => u.Id == userId)
            .FirstOrDefaultAsync();

            return user;
        }
    }
}