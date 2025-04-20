using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioAutor : IRepositorioAutor

    {

        private ApplicationDbContext _context;
        public RepositorioAutor(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Add(Autor nuevo)
        {
             _context.Entry(nuevo.Nacionalidad).State = EntityState.Unchanged;
            _context.Autores.Add(nuevo);
            _context.SaveChanges();
            return nuevo.Id;
        }

        public List<Autor> FindAll()
        {
            return _context.Autores.Include(a => a.Nacionalidad).ToList();
        }

        public Autor FindById(int id)
        {
            return _context.Autores.Include(a=>a.Nacionalidad).Where(a=>a.Id.Equals(id)).SingleOrDefault();
        }

        public void Remove(int id)
        {
            Autor b = _context.Autores.Where(x => x.Id == id).SingleOrDefault();
            _context.Autores.Remove(b);
            _context.SaveChanges();

        }

        public int Update(Autor obj)
        {
            _context.Autores.Update(obj);
            _context.SaveChanges();
            return obj.Id;  
                
        }
    }
}
