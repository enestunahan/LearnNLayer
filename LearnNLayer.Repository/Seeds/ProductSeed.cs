using LearnNLayer.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LearnNLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
               new Product()
               {
                   Id = 1,
                   CategoryId = 1,
                   Name = "Kalem 1",
                   Stock = 100,
                   Price = 50,
                   CreatedTime = DateTime.Now
               },
               new Product()
               {
                   Id = 2,
                   CategoryId = 1,
                   Name = "Kalem 2",
                   Stock = 10,
                   Price = 30,
                   CreatedTime = DateTime.Now
               },
               new Product()
               {
                   Id = 3,
                   CategoryId = 1,
                   Name = "Kalem 3",
                   Stock = 150,
                   Price = 10,
                   CreatedTime = DateTime.Now
               },
                new Product()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Kitap 1",
                    Stock = 170,
                    Price = 30,
                    CreatedTime = DateTime.Now
                }
               );
        }
    }
}
