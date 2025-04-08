using Libreria.DTOs.DTOs.DTOsPais;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUPais
{
    public class CUObtenerPaises : ICUObtenerPaises
    {
        private IRepositorioPais _repoPais;

        public CUObtenerPaises(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }
        public List<DTOPais> ObtenerPaises()
        {

            return MapperPais.FromListPaisToListDtoPais(_repoPais.FindAll());

            //List<Pais> paises = _repoPais.FindAll();
            //List<DTOPais> listaRetorno = MapperPais.FromListPaisToListDtoPais(paises);
            //return listaRetorno;
        }
    }
}
