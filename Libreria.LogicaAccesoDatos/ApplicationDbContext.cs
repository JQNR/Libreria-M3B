using Libreria.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Usuario> Clientes { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Ebook> Ebooks { get; set; }
        public DbSet<Fisico> Fisico { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*Debido a que el VO NombreCompleto es compartido, es necesario configurar aquí
            Note que si el VO no es compartido, alcanza con [ComplexType] en lugar de configurar con FluentAPI
             */
            modelBuilder.Entity<Autor>().OwnsOne(a => a.NombreCompleto, n =>
            {
                n.Property(p => p.Nombre).HasColumnName("Nombre");
                n.Property(p => p.Apellido).HasColumnName("Apellido");
            });
            modelBuilder.Entity<Usuario>().OwnsOne(a => a.NombreCompleto, n =>
            {
                n.Property(p => p.Nombre).HasColumnName("Nombre");
                n.Property(p => p.Apellido).HasColumnName("Apellido");
            });

            //Herencia de libro TPH
            // Configuración de la herencia TPH
            modelBuilder.Entity<Libro>()
                .HasDiscriminator<string>("TipoDeLibro")
                .HasValue<Fisico>("LibroFisico")
                .HasValue<Ebook>("Ebook");



            // Configuración de la entidad usuario
            modelBuilder.Entity<Usuario>()
                .HasIndex(c => c.Email)
                .IsUnique(); // Crea un índice único para el campo Email

            // Configuro many to many de libro y genero, sin propiedad de navegación de genero a libro
            modelBuilder.Entity<Libro>()
               .HasMany(l => l.Generos)
               .WithMany() // sin propiedad de navegación en Genero
               .UsingEntity(j => j.ToTable("LibroGenero"));



            /*Configuro el tipo de dato decimal para EF core*/
            modelBuilder.Entity<DetalleVenta>()
                .Property(d => d.PrecioUnidad)
                .HasPrecision(18, 4); // o HasColumnType("decimal(18,4)")

            modelBuilder.Entity<Ebook>()
                .Property(e => e.Size)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Libro>()
                .Property(l => l.Precio)
                .HasPrecision(18, 4);


            //Relacion multiple entre venta y usuario
                    modelBuilder.Entity<Venta>()
                .HasOne(v => v.Vendedor)
                .WithMany()
                .HasForeignKey(v => v.VendedorId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Venta>()
               .HasOne(v => v.Cliente)
               .WithMany()
               .HasForeignKey(v => v.ClienteId)
               .OnDelete(DeleteBehavior.Restrict); 

        }


    }
}
