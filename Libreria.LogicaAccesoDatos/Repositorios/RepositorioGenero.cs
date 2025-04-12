using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioGenero:IRepositorioGenero
    {
    
        private ApplicationDbContext _context;
        public RepositorioGenero(ApplicationDbContext context)
        {
            _context = context;
        }



        public int Add(Genero genero)
        {

            _context.Generos.Add(genero);
            _context.SaveChanges();
            return genero.Id;
        }

        public int Update(Genero genero)
        {
            _context.Generos.Update(genero);
            _context.SaveChanges();
            return genero.Id;

        }

        public List<Genero> FindAll()
        {

            return _context.Generos.ToList();
        }

        public Genero FindById(int id)
        {

          return _context.Generos.Find(id);
        }

        public void Remove(int id)
        {
           _context.Remove(id);
            _context.SaveChanges();
        }

        public List<Genero> FindByEdadMinima(int edad)
        {
            return _context.Generos.Where(x => x.EdadMinima == edad).ToList();
        }

        public Genero GetGeneroByNombre(string nombre)
        {
            return _context.Generos.Where(x => x.Nombre == nombre).SingleOrDefault();
        }
    }
}
