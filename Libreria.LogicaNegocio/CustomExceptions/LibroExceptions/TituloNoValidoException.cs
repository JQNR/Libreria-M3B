using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.CustomExceptions.LibroExceptions
{
    public class TituloNoValidoException : Exception
    {
        public TituloNoValidoException(string? message) : base(message)
        {
        }
    }
}
