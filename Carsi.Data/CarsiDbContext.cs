using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carsi.Data.Concrete;
using Carsi.Data.Concrete.Configuration;
using Carsi.Entity;
using Carsi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Carsi.Data
{
    public class CarsiDbContext:DbContext
    {
       
        public CarsiDbContext  (DbContextOptions options):base(options)
        {
              
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Sepet> Sepets { get; set; }

        public DbSet<Item> Items { get; set; }
    }

   
    
}