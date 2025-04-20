using Libreria.DTOs.DTOs.DTOsAutor;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAplicacion.ICasosUso.ICUAutor;
using Libreria.LogicaAplicacion.ICasosUso.ICUGenero;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUAutor
{
    public class CUObtenerAutores:ICUObtenerAutores
    {
        private IRepositorioAutor _repositorioAutor;
 

        public CUObtenerAutores(IRepositorioAutor repositorioAutor )
        {
            _repositorioAutor = repositorioAutor;
           
        }

        public List<DTOAutor> ObtenerAutores()
        {
            List<Autor> autores = _repositorioAutor.FindAll();
            return MapperAutor.FromListToListDto(autores);
        }
    }
}
