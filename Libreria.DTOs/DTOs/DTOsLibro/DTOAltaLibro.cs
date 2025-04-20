using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.VO.LIbro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.DTOs.DTOsLibro
{
    public class DTOAltaLibro
    {
        //Aquí hay que pensar qué datos preciso para poder dar de alta un libro, ya sea físico o ebook
        //y prever todos los campos para eso.
        public string TipoLibro  { get; set; }
        public int Id { get; set; }
        public string TituloOriginal { get; set; }
        public string TituloAlternativo { get; set; }
        public int IdAutor { get; set; }
        public decimal Precio { get; set; }
        public List<int> IdsGeneros { get; set; }
        public string? Portada { get; set; }//Se deja para más adelante para ver FileUpload
        public int? Stock { get; set; }
        public int? CantidadPaginas { get; set; }
        public string? Formato { get; set; }
        public decimal? Size { get; set; }



    }
}
