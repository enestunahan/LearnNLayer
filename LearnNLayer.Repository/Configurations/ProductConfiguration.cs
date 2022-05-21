using LearnNLayer.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LearnNLayer.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           builder.HasKey(x => x.Id);
           builder.Property(x=>x.Id).UseIdentityColumn();

           builder.Property(x=>x.Name).HasMaxLength(256);
           builder.Property(x=>x.Stock).IsRequired();

           builder.Property(x => x.Price).HasColumnType("decimal(18,2)");

            builder.HasOne(x=>x.Category).WithMany(x=>x.Products).HasForeignKey(x=>x.CategoryId);
        }
    }
}
