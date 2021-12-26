using GestionProduit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionProduit.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(prod => prod.Providers).WithMany(prov => prov.Products)
                    .UsingEntity(j => j.ToTable("Providings"));
            builder.HasOne(prod => prod.Category).WithMany(cat => cat.Products).OnDelete(DeleteBehavior.Cascade);

        }
    }
}