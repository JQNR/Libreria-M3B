using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.CustomExceptions.GeneroExceptions
{
    public class EdadMinimaException : Exception
    {
        public EdadMinimaException():base("La edad no puede ser negativa")
        {
        }

        public EdadMinimaException(string? message) : base(message)
        {
        }
    }
}
