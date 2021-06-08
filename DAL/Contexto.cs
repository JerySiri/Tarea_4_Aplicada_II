using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFCoreTutorial.Models;

namespace EFCoreTutorial.DAL
{
    public class Contexto : DbContext
    {
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<Articulo> Articulos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Pelicula> Peliculas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source= DESKTOP-IROCOAA\SQLEXPRESS;Database=ejemploDB;Trusted_Connection=True;");
            
        }
    }
}
