using Libreria.DTOs.DTOs.DTOsGenero;
using Libreria.DTOs.Mappers;
using Libreria.LogicaAplicacion.ICasosUso.ICUGenero;
using Libreria.LogicaNegocio.CustomExceptions.GeneroExceptions;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUGenero
{
    public class CUActualizarGenero : ICUActualizarGenero
    {
        private IRepositorioGenero _repoGenero;
        private IRepositorioAuditoria _repoAuditoria;


        public CUActualizarGenero(IRepositorioGenero repoGenero, IRepositorioAuditoria repoAuditoria)
        {
            _repoGenero = repoGenero;
            _repoAuditoria = repoAuditoria;
        }
        public void ActualizarGenero(DTOGenero dto)
        {
            try
            {
                Genero g = MapperGenero.FromDtoGeneroToGenero(dto);
                g.Validar();
                int r = _repoGenero.Update(g);



                Auditoria aud = new Auditoria(dto.LogueadoId, "UPDATE", "GENERO", r.ToString(), "Actualización correcta");
                _repoAuditoria.Auditar(aud);
            }
            catch (EdadMinimaException e)
            {
                Auditoria aud = new Auditoria(dto.LogueadoId, "UPDATE", "GENERO", null, e.Message);
                _repoAuditoria.Auditar(aud);
                throw e;
            }
            catch (NombreGeneroException e)
            {
                Auditoria aud = new Auditoria(dto.LogueadoId, "UPDATE", "GENERO", null, e.Message);
                _repoAuditoria.Auditar(aud);
                throw e;
            }
            catch (Exception e)
            {
                Auditoria aud = new Auditoria(dto.LogueadoId, "UPDATE", "GENERO", null, e.Message);
                _repoAuditoria.Auditar(aud);
                throw e;
            }

        }
    }
}
