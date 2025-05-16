using DemoEFCorePostgreSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEFCorePostgreSQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public  DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=ProductosDb;Username=postgres;password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("productos");
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Nombre).HasMaxLength(100).IsRequired();
                entity.Property(p => p.Precio);
            });
        }

    }
}
