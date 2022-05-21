using LearnNLayer.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LearnNLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature() { Id = 1 ,ProductId = 1, Color = "Kırmızı" ,Height = 100 , Width = 200 },
                new ProductFeature() { Id = 2, ProductId = 2, Color = "Mavi", Height = 100, Width = 200 });
        }
    }
}
