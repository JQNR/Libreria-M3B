using Libreria.DTOs.DTOs.DTOsGenero;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAccesoDatos.Repositorios;
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

    public class CUListarGeneros:ICUListarGeneros
    {
        private IRepositorioGenero _repoGenero;

        public CUListarGeneros(IRepositorioGenero repoGenero)
        {
            _repoGenero = repoGenero;
        }

        public List<DTOGenero> ListarGeneros() { 
        

            List<Genero> generos =  _repoGenero.FindAll();

            List<DTOGenero> listDtoParaRetornar = MapperGenero.FromListGeneroToListDtoGenero(generos);
            return listDtoParaRetornar;
        }

    }
}
