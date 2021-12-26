using GestionProduit.Models;
using Microsoft.EntityFrameworkCore;
using GestionProduit.Configurations;
using System.Linq;

namespace GestionProduit.Data
{
    public class GPContext : DbContext
    {
        public GPContext() : base()
        {
            // Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=GestionProduit;Integrated Security=True;");
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=GestionProduit;User=SA;Password=reallyStrongPassword123");

            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ChemicalConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());


            //Configuration each proporty starting with Name

            foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(string) && p.Name.StartsWith("Name"))
            )
            {
                property.SetColumnName("MyName");
            }


            // modelBuilder.Entity<Product>().HasDiscriminator<int>("IsBiological")
            //     .HasValue<Product>(0).HasValue<Biological>(1).HasValue<Chemical>(2);


            modelBuilder.ApplyConfiguration(new FactureConfigutation());

            modelBuilder.Entity<Chemical>().ToTable("Chemicals");
            modelBuilder.Entity<Biological>().ToTable("Biologicals");
            base.OnModelCreating(modelBuilder);
        }
    }
}