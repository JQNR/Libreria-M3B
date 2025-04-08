using Libreria.LogicaNegocio.VO.LIbro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Ebook:Libro
    {
        public Ebook(TituloLibro titulo, Autor autor, decimal precio, string formato, decimal size) : base(titulo, autor, precio)
        {
            Formato = formato;
            Size = size;
        }
        public Ebook():base(){}
        
        public string Formato { get; set; }
        public decimal Size { get; set; }

    }
}
