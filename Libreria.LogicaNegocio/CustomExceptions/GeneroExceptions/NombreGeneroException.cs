using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.CustomExceptions.GeneroExceptions
{
    public class NombreGeneroException : Exception
    {
        public NombreGeneroException():base("El nombre no puede ser vacío")
        {
            
        }

        public NombreGeneroException(string? message) : base(message)
        {
        }
    }
}
