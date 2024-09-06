using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Carsi.Shared.DTOS
{
    public class ItemDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int SepetId { get; set; }
        [JsonIgnore]
        public SepetDto Sepet { get; set; }
        public int Adet { get; set; }
    }
}