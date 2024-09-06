using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Shared.DTOS
{
    public class SepetDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public List<ItemDto> Items { get; set; }

        public bool Confirm { get; set; } 
    }
        
}