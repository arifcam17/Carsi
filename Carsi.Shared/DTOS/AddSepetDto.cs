using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Carsi.Shared.DTOS
{
    public class AddSepetDto
    {
        public int ProductId { get; set; }
        public string UserId { get;set; }

       public int Quantity { get; set; }
         
    }
        
}