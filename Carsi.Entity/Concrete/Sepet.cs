using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Abstract;
using Carsi.Entity.Concrete;

namespace Carsi.Entity.Concrete
{
    public class Sepet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
       
        public DateTime CreatedDate { get; set; }
        
      public List<Item> Items { get; set; }
        
        
    }
}