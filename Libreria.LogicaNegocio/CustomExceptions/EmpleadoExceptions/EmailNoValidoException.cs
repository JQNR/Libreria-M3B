using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.CustomExceptions.EmpleadoExceptions
{
    public class EmailNoValidoException:Exception
    {
        public EmailNoValidoException(string msg):base(msg)
        {
        
        }
    }
}
