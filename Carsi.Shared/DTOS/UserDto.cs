using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Shared.DTOS
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Password { get; set; }   
        public string Email { get; set; }
        
        
    }
}