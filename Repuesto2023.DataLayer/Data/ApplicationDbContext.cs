﻿using Microsoft.EntityFrameworkCore;
using Repuestos2023.Models.Models;

namespace Repuestos2023.DataLayer.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Provincia>().HasData(
                    new Provincia { ProvinciaId = 1, Nombre = "Buenos Aires"}
               );
            modelBuilder.Entity<Ciudad>().HasData(
                    new Ciudad { CiudadId = 1, Nombre = "Lobos", ProvinciaId = 1 }
               );

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
    }
}
