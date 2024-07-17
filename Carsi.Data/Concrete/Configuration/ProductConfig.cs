using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carsi.Data.Concrete.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);  
            builder.Property(x => x.Name);
            builder.ToTable("Products");
           
            builder.HasData(
                new Product{
                    Id = 1,
                    Name = "telefon",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl=""
                    
                },
                new Product{
                    Id = 2,
                    Name = "saat",
                    IsActive=false,
                    IsHome=false,
                    Price=10,
                    Stock=1,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl=""
                    

                },
                new Product{
                    Id = 3,
                    Name = "kulaklik",
                    IsActive=false,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="",
                    
                }
            );
        }
    }
}