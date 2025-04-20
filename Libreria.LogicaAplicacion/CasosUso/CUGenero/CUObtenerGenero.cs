using Libreria.DTOs.DTOs.DTOsGenero;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAplicacion.ICasosUso.ICUGenero;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUGenero
{
    public class CUObtenerGenero : ICUObtenerGenero
    {
        private IRepositorioGenero _repoGenero;

        public CUObtenerGenero(IRepositorioGenero repoGenero)
        {
            _repoGenero = repoGenero;
        }
        public DTOGenero ObtenerGenero(int id)
        {
           Genero b = _repoGenero.FindById(id);
           return MapperGenero.FromGeneroToDtoGenero(b);
            //TODO AUDITAR discutir por qué sería bueno
        }
    }
}
