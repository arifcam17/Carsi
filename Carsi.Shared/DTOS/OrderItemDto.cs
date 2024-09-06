using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Carsi.Shared.DTOS
{
    public class OrderItemDto
    {
        public int Id { get; set; } 
        public int OderId { get; set; }
        [JsonIgnore]
        public OrderDto Order { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public ProductDto ProductDto { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}