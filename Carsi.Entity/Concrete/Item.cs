using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Entity.Concrete
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SepetId { get; set; }
        public Sepet Sepet { get; set; }
        public int Adet { get; set; }
    }
}