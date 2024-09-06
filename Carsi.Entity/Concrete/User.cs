using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Abstract;

namespace Carsi.Entity.Concrete
{
    public class User:IBaseEntity,ICommonEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Password { get; set; }   
        public string Email { get; set; }
       
        
        
        public DateTime CreatedDate { get ; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive        { get ; set; }
    }
}