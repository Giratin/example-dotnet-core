using Microsoft.EntityFrameworkCore;
using GestionProduit.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionProduit.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("MyCategories");
            builder.HasKey(cat => cat.CategoryID);
            builder.Property(cat => cat.Name).IsRequired().HasMaxLength(50);
        }
    }
}