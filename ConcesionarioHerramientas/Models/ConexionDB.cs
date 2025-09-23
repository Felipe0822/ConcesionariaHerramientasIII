using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioHerramientas.Models
{
    public class ConexionDB : DbContext
    {
        public ConexionDB()
        {
        }

        public ConexionDB(DbContextOptions<ConexionDB> options) : base(options)
        {
        }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Automoviles> Automovil { get; set; }
        public DbSet<Ventas> Venta { get; set; }
        public DbSet<Marcas> Marca { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=FELIPE\\SQLEXPRESS;Database=ConcesionarioDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automoviles>()
                .HasKey(a => a.IdAutomovil);
            modelBuilder.Entity<Clientes>()
                .HasKey(a => a.IdCliente);
            modelBuilder.Entity<Marcas>()
                .HasKey(a => a.IdMarca);
            modelBuilder.Entity<Ventas>()
                .HasKey(a => a.IdVenta);

            base.OnModelCreating(modelBuilder);
        }
    }
}
