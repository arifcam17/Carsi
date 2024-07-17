using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carsi.Data.Concrete.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           // builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); 
            builder.Property(x => x.Name);
            
            builder.ToTable("Users");
           
            builder.HasData(
                new User{
                    Id = 1,
                    Name = "Alex",
                    Password="123456",
                    Email="alex@xxx"

                },
                new User{
                    Id = 2,
                    Name = "Quaresma",
                    Password="12345",
                    Email="q@xxx"

                },
                new User{
                    Id = 3,
                    Name = "Arda Guler",
                    Password="123",
                    Email="arda@xxx"

                }
            );

        }
    }
}