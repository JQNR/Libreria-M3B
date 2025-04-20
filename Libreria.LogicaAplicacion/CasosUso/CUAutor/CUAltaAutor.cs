using Libreria.DTOs.DTOs.DTOsAutor;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAplicacion.ICasosUso.ICUAltaAutor;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUAutor
{
    public class CUAltaAutor : ICUAltaAutor
    {
        private IRepositorioAutor _repositorioAutor;
        private IRepositorioPais _repoitorioPais;

        public CUAltaAutor(IRepositorioAutor repositorioAutor, IRepositorioPais repoitorioPais)
        {
            _repositorioAutor = repositorioAutor;
            _repoitorioPais = repoitorioPais;
        }
        public void AltaAutor(DTOAltaAutor dto)
        {

            Autor nuevo = MapperAutor.FromAltaAutorToAutor(dto);
           // Pais Paisbuscado = _repoitorioPais.FindById(dto.PaisId);
            //nuevo.Nacionalidad = Paisbuscado;


            _repositorioAutor.Add(nuevo);
        }
    }
}
