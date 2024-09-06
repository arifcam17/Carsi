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
           //  builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); 
            builder.Property(x => x.Name);
            
            builder.ToTable("Users");
           
            builder.HasData(
                new User{
                    Id = 1,
                    Name = "Mehmet Kara",
                    Password="123456",
                    Email="memo@xxx"

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

                },
                new User{
                    Id = 4,
                    Name = "hasan",
                    Password="1",
                    Email="aa"

                },
                new User{
                    Id = 5,
                    Name = "suat",
                    Password="suke",
                    Email="xxx"

                },
                new User{
                    Id = 6,
                    Name = "Cemil",
                    Password="78",
                    Email="@"

                },
                new User{
                    Id = 7,
                    Name = "macit",
                    Password="m",
                    Email="157"

                },
                new User{
                    Id = 8,
                    Name = "haci",
                    Password="7",
                    Email="sabanci"

                },
                new User{
                    Id = 9,
                    Name = "muhtelif",
                    Password="1923",
                    Email="s"

                }
            );

        }
    }
}