using Libreria.LogicaNegocio.VO.LIbro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public abstract class Libro
    {
        public int Id { get; set; }
        public TituloLibro Titulo { get; set; }
        public Autor Autor { get; set; }
        public decimal Precio { get; set; }
        public List<Genero>Generos { get; set; }
        public string? Portada { get; set; }

        protected Libro(TituloLibro titulo, Autor autor, decimal precio)
        {
            Titulo = titulo;
            Autor = autor;
            Precio = precio;
            Generos = new List<Genero>();    
        }
        protected Libro()
        {
            Generos = new List<Genero>();
        }
    }
}
