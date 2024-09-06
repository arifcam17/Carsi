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
                    Name = "IPhone 13 Promax",
                    IsActive=true,
                    IsHome=true,
                    Price=1000,
                    Stock=850,
                    Description="njer eirfoierm oiedmcoediw oeidcoie",
                    ImageUrl="iphone.jpg"
                    
                },
                new Product{
                    Id = 2,
                    Name = "samsung galaxy",
                    IsActive=true,
                    IsHome=false,
                    Price=750,
                    Stock=150,
                    Description="flskdmgflkdslkfl slkdfnlkdsn lksjdnflksjd sjdfj jdsnfjkds jdsnf kjgj jewnwew lkewjf",
                    ImageUrl="android.jpg"
                    

                },
                new Product{
                    Id = 3,
                    Name = "newton kulaklik",
                    IsActive=false,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="kulaklik.jpg",
                    
                },new Product{
                    Id = 4,
                    Name = "mac",
                    IsActive=true,
                    IsHome=true,
                    Price=1200,
                    Stock=100,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="macbook.jpg"
                    
                },
                new Product{
                    Id = 5,
                    Name = "iped",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="iped.jpg"
                    
                },new Product{
                    Id = 6,
                    Name = "airpod",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="airpod.jpg"
                    
                },new Product{
                    Id = 7,
                    Name = "kablosuz sarj",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=100,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="kablosuz.jpg"
                    
                },new Product{
                    Id = 8,
                    Name = "adaptor",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="adaptor.jpg"
                    
                },new Product{
                    Id = 9,
                    Name = "powerbank1",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="pbank2.jpg"
                    
                },new Product{
                    Id = 10,
                    Name = "powerbank2",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="pb.jpg"
                    
                },new Product{
                    Id = 11,
                    Name = "air sarj",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="kablosuz2.jpg"
                    
                },new Product{
                    Id = 12,
                    Name = "vision pro",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="vision.jpg"
                    
                },new Product{
                    Id = 13,
                    Name = "multi giris",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="multi.jpg"
                    
                },new Product{
                    Id = 14,
                    Name = "saat",
                    IsActive=true,
                    IsHome=true,
                    Price=100,
                    Stock=10,
                    Description="asda sadasd sdasd asdsadsada",
                    ImageUrl="watch.jpg"
                    
                }

            );
        }
    }
}