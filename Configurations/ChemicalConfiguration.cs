using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionProduit.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(ch => ch.Address).Property(ad => ad.StreetAddress)
                    .HasColumnName("MyAddress").HasMaxLength(50);

            builder.OwnsOne(ch => ch.Address).Property(ad => ad.City)
                .IsRequired().HasColumnName("MyCity");

        }
    }
}