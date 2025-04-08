using Libreria.LogicaAccesoDatos;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.VO.Compartidos;
using Libreria.LogicaNegocio.VO.LIbro;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Libreria.Test_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
             ESTE ES UN PROYECTO QUE PERMITE CONECTAR CON LA BASE DE DATOS DIRECTAMENTE DESDE LA CONSOLA, PARA PODER PROBAR A MANO
             HACER CRUDS, Y EXPERIMENTAR CON EL MODELO DE DATOS.
             LA VARIABLE _context SOLO ESTÁ DISPONIBLE DENTRO DEL using(){}
             LA CADENA DE CONEXIÓN PUEDE SER LOCAL EN EL EQUIPO, PERO LA MIGRACIÓN DEBE REALIZARSE DESDE EL PROYECTO MVC COMO DE COSTUMBRE.
             */
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer("Server=jqndevs.ddns.net,8443;Database=Libreria;User Id=sqlremoteuser;Password=Abcd1234;TrustServerCertificate=True;"))
                .BuildServiceProvider();

            using (var _context = serviceProvider.GetRequiredService<ApplicationDbContext>())
            {


                //Pais p1 = new Pais();
                //p1.Nombre = "España";
                //p1.Codigo = "ESP";

                //_context.Paises.Add(p1);
                //_context.SaveChanges();

                //Console.WriteLine("");


                //int idPais = 1;

                //Pais PaisDelAutor = _context.Paises.Find(idPais);

                //Autor autorNuevo = new Autor();
                //autorNuevo.NombreCompleto = new NombreCompleto("Miguel", "De Cervantes");
                //autorNuevo.Nacionalidad = PaisDelAutor;

                //_context.Autores.Add(autorNuevo);
                //_context.SaveChanges();


                //BORRAR
                //int idPais = 2;

                //Pais Aborrar = _context.Paises.Find(idPais);
                //_context.Paises.Remove(Aborrar);    
                //_context.SaveChanges();
                //Console.WriteLine();

                //UPdate

                //Autor Buscado = _context.Autores.Find(1);
                //NombreCompleto nuevoNombre = new NombreCompleto("Miguel", "De Cervantes Saavedra");
                //Buscado.NombreCompleto = nuevoNombre;
                //_context.Update(Buscado);
                //_context.SaveChanges();


                //ALTA DE LIBRO

                //Autor a = _context.Autores.Find(1);
                //Genero g1 = _context.Generos.Find(1);
                //Genero g2 = _context.Generos.Find(2);
                //Fisico lf = new Fisico();
                //lf.Titulo = new TituloLibro("El Quijote", "El ingenioso hidalgo Don Quijote de la Mancha");
                //lf.Stock = 50;
                //lf.CantidadPaginas = 950;
                //lf.Precio = 1250;
                //lf.Autor = a;
                //lf.Generos.Add(g1);
                //lf.Generos.Add(g2);
                //_context.Libros.Add(lf);
                //_context.SaveChanges();

                //Console.WriteLine();

                Libro? libro = _context.Libros.Where(l=>l.Id==1)
                                .Include(x=>x.Autor).ThenInclude(j=>j.Nacionalidad)
                                .Include(l=>l.Generos)
                                .SingleOrDefault();
                Console.WriteLine();











                //CREATE OR UPDATE
                //Genero g1 = new Genero();
                //g1.Nombre = "DRAMAAAAAA";
                //g1.EdadMinima = 8;
                //g1.Id = 0;

                //_context.Generos.Update(g1);
                //_context.SaveChanges();


                //Genero AEliminar = _context.Generos.Find(2);
                //_context.Generos.Remove(AEliminar);
                //_context.SaveChanges();

                //Pais p1 = new Pais();
                //p1.Nombre = "España";
                //p1.Codigo = "ESP";
                //_context.Paises.Add(p1);
                //_context.SaveChanges();


                //Pais PaisBuscado = _context.Paises.Where(x=>x.Nombre=="España").SingleOrDefault();

                //Autor a1 = new Autor();
                //a1.NombreCompleto = new NombreCompleto("Miguel", "de Cervantes Saavedra");
                //a1.Nacionalidad = PaisBuscado;
                //_context.Autores.Add(a1);   
                //_context.SaveChanges();


                // Autor autorDelquijote = _context.Autores.Where(x=>x.Id==1).SingleOrDefault();
                //Fisico l1 = new Fisico();
                //l1.Titulo = new TituloLibro("El ingenioso hidalgo Don Quijote de la Mancha", "El ingenioso hidalgo Don Quijote de la Mancha");
                //l1.Autor = new Autor() { Id=1};
                //l1.Precio = 500;
                //l1.Stock = 40;
                //l1.CantidadPaginas = 900;
                //_context.Entry(l1.Autor).State = EntityState.Unchanged;
                //_context.Libros.Add(l1);
                //_context.SaveChanges();

                //Agrego generos al libro

                //Genero c1 = _context.Generos.Find(3);
                //Genero c2 = _context.Generos.Find(1);

                //Libro quijote = _context.Libros.Find(1);

                //quijote.Generos.Add(c1);
                //quijote.Generos.Add(c2);
                //_context.Libros.Update(quijote);
                //_context.SaveChanges();







            }



        }
    }
}
