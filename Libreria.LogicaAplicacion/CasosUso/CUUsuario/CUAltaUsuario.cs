
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
using System.Text.Json;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUEmpleado
{
    public class CUAltaUsuario : ICUAltaUsuario
    {
        private IRepositorioUsuario _repoUsuario;
        private IRepositorioAuditoria _repoAuditoria;

        public CUAltaUsuario(IRepositorioUsuario repoUsuario, IRepositorioAuditoria repoAuditoria)
        {
            _repoUsuario = repoUsuario;
            _repoAuditoria = repoAuditoria;
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
                int idEntidad =  _repoUsuario.Add(nuevo);

                Auditoria aud = new Auditoria(dto.LogueadoId, "ALTA", nuevo.GetType().Name, idEntidad.ToString(), "Alta correcta"+ JsonSerializer.Serialize(nuevo));

                _repoAuditoria.Auditar(aud);
            }
            catch (Exception e)
            {
                Auditoria aud = new Auditoria(dto.LogueadoId, "ALTA", "Usuario", null, "ERROR: "+e.Message);

                _repoAuditoria.Auditar(aud);
                //TODO Audito el problema
                throw e;
            }

        }
    }
}
