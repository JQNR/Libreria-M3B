
using Libreria.DTOs.DTOs.DTOsUsuario;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAplicacion.ICasosUso.ICUEmpleado;
using Libreria.LogicaNegocio.CustomExceptions.EmpleadoExceptions;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUEmpleado
{
    public class CUAltaUsuario : ICUAltaUsuario
    {
        private IRepositorioUsuario _repoUsuario;

        public CUAltaUsuario(IRepositorioUsuario repoUsuario)
        {
            _repoUsuario = repoUsuario;
        }


        public void AltaEmpleado(DTOAltaUsuario dto)
        {
            try
            {
                Usuario buscado = _repoUsuario.FindByEmail(dto.Email);
                if (buscado != null)
                {
                    throw new EmailYaExisteException("EL email ya existe");
                }


                Usuario nuevo = MapperUsuario.ToUsuario(dto);
                _repoUsuario.Add(nuevo);
            }
            catch (Exception e)
            {
                //TODO Audito el problema
                throw e;
            }

        }
    }
}
