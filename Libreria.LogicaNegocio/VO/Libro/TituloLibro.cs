using Libreria.LogicaNegocio.CustomExceptions.LibroExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.VO.LIbro
{
    [ComplexType]
    public record TituloLibro
    {
        public string Titulo { get; init; }
        public string TituloOriginal { get; init; }

        public TituloLibro(string titulo, string tituloOriginal)
        {
            Titulo = titulo;
            TituloOriginal = tituloOriginal;
        }

        public void Validar() {
            if (string.IsNullOrEmpty(TituloOriginal))
                throw new TituloNoValidoException("El título original no es válido");
            if (string.IsNullOrEmpty(Titulo))
                throw new TituloNoValidoException("El título no es válido");

        }
    }
}
