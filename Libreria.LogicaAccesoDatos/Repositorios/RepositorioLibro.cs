using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioLibro : IRepositorioLibro
    {

        private ApplicationDbContext _context;
        public RepositorioLibro(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Add(Libro nuevo)
        {
            _context.Libros.Add(nuevo);
            _context.SaveChanges();
            return nuevo.Id;

        }

        public List<Libro> FindAll()
        {
            return _context.Libros.ToList();

        }

        public Libro FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Libro obj)
        {
            throw new NotImplementedException();
        }
    }
}
