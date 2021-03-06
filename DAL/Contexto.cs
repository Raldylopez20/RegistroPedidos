using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RegistroPedidos.Entidades;


namespace RegistroPedidos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\Ordenes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 1, Descripcion = "galletas", Costo = 45.5, Inventario = 87 });
            modelBuilder.Entity<Productos>().HasData(new Productos 

            { ProductoId = 2, Descripcion = "Fire Ball", Costo = 1000.00, Inventario = 53 });

            modelBuilder.Entity<Suplidores>().HasData(new Suplidores 
            { SuplidorId = 1, Nombres = "Palmares" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores 
            
            { SuplidorId = 2, Nombres = " Sazerac Co." });
        }
    }
}