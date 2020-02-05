using servicerequest.api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicerequest.api.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductServices> ProductServices { get; set; }
        public DbSet<ServiceRequests> ServiceRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData
            (
                new Product { ProductId = 1, ProductName = "plumber service" },
                new Product { ProductId = 2, ProductName = "kitchen item Service" },
                new Product { ProductId = 3, ProductName = "wood working services" }
                
            );

            builder.Entity<ProductType>().HasData
            (
               
                new ProductType { ProductTypeId = 3, ProductId = 2, ProductTypeName = "Service Type" },
                new ProductType { ProductTypeId = 4, ProductId = 2, ProductTypeName = "gas stove" },
                new ProductType { ProductTypeId = 5, ProductId = 1, ProductTypeName = "House" },
                new ProductType { ProductTypeId = 6, ProductId = 1, ProductTypeName = "Hotel" },
                new ProductType { ProductTypeId = 7, ProductId = 3, ProductTypeName = "Doors" },
                new ProductType { ProductTypeId = 8, ProductId = 3, ProductTypeName = "cottage" }
            );

            builder.Entity<ProductServices>().HasData
           (
              
               new ProductServices { ProductServiceId = 3, ProductTypeId = 3, ProductServiceName = "gas stove" },
               new ProductServices { ProductServiceId = 4, ProductTypeId = 3, ProductServiceName = "cooker" },
               new ProductServices { ProductServiceId = 5, ProductTypeId = 4, ProductServiceName = "gas stove 3" },
               new ProductServices { ProductServiceId = 6, ProductTypeId = 5, ProductServiceName = "kitchen" },
               new ProductServices { ProductServiceId = 7, ProductTypeId = 5, ProductServiceName = "Restroom" },
               new ProductServices { ProductServiceId = 8, ProductTypeId = 6, ProductServiceName = "Garden plumber work" },
               new ProductServices { ProductServiceId = 9, ProductTypeId = 7, ProductServiceName = "Single door" },
               new ProductServices { ProductServiceId = 10, ProductTypeId = 7, ProductServiceName = "Window doors" },
               new ProductServices { ProductServiceId = 11, ProductTypeId = 8, ProductServiceName = "Single cottage " },
               new ProductServices { ProductServiceId = 12, ProductTypeId = 8, ProductServiceName = "Double cottage" }
           );

        }
    }
}
