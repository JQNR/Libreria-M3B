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
    public class CUAltaPais : ICUAltaPais
    {

        private IRepositorioPais _repoPais;

        public CUAltaPais(IRepositorioPais repoPais)
        {
            _repoPais = repoPais;
        }
        public void AltaPais(DTOAltaPais dto)
        {
            Pais p = MapperPais.FromDTOPaisToPais(dto);
            _repoPais.Add(p);
        }
    }
}
