using Libreria.LogicaNegocio.VO.LIbro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Fisico:Libro
    {
        public Fisico(TituloLibro titulo, Autor autor, decimal precio, int stock, int cantidadPaginas) : base(titulo, autor, precio)
        {
            Stock = stock;
            CantidadPaginas = cantidadPaginas;

        }
        public Fisico():base(){}
       
        public int Stock { get; set; }
        public int CantidadPaginas { get; set; }

    }
}
