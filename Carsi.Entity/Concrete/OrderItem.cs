using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Entity.Concrete
{
    public class OrderItem
    {
        public int Id { get; set; } 
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}