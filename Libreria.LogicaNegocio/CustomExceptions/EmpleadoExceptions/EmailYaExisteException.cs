using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.CustomExceptions.EmpleadoExceptions
{
    public class EmailYaExisteException : Exception
    {
        public EmailYaExisteException(string? message) : base(message)
        {
        }
    }
}
