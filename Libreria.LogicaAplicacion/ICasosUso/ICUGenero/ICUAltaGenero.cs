using Libreria.DTOs.DTOs.DTOsGenero;
using Libreria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.ICasosUso.ICUGenero
{
    public interface ICUAltaGenero
    {
        void AltaGenero(DTOAltaGenero nuevo);
    }
}
