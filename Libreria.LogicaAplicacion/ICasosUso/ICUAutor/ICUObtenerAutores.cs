using Libreria.DTOs.DTOs.DTOsAutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.ICasosUso.ICUAutor
{
    public interface ICUObtenerAutores
    {
        List<DTOAutor> ObtenerAutores();
    }
}
