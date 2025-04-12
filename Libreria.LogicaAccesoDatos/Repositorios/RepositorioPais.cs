using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAccesoDatos.Repositorios
{
    public class RepositorioPais : IRepositorioPais
    {

        private ApplicationDbContext _context;
        public RepositorioPais(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Add(Pais nuevo)
        {
            _context.Paises.Add(nuevo);
            _context.SaveChanges();
            return nuevo.Id;
        }

        public List<Pais> FindAll()
        {
            return _context.Paises.ToList();
        }

        public Pais FindById(int id)
        {
           return _context.Paises.Find(id);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Pais obj)
        {
            throw new NotImplementedException();
        }
    }
}
