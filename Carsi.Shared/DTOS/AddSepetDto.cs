using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Carsi.Shared.DTOS
{
    public class AddSepetDto
    {
        public int Id { get; set; }
        public int UserId { get;set; }

       
         
       public DateTime CreatedDate { get; set; }
    }
        
}