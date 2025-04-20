using Libreria.DTOs.DTOs.DTOsGenero;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.ICasosUso.ICUGenero;
using Libreria.LogicaNegocio.CustomExceptions.GeneroExceptions;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUGenero
{
    public class CUAltaGenero:ICUAltaGenero
    {
        private IRepositorioGenero _repoGenero;

        public CUAltaGenero(IRepositorioGenero repoGenero)
        {
            _repoGenero = repoGenero;
        }

        public void AltaGenero(DTOAltaGenero nuevo) {

            Genero g = MapperGenero.FromDtoAltaGenero(nuevo);
            Genero buscado = _repoGenero.GetGeneroByNombre(nuevo.Nombre);
            _repoGenero.Add(g);
            //TODO AUDITAR
           
        }

    }
}
