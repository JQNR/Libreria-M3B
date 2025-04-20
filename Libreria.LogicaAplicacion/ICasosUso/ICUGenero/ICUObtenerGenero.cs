using Libreria.DTOs.DTOs.DTOsGenero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.ICasosUso.ICUGenero
{
    public interface ICUObtenerGenero
    {
        DTOGenero ObtenerGenero(int id);
    }
}
