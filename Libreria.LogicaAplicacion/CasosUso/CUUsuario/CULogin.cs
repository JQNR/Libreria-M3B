using Libreria.DTOs.DTOs.DTOsUsuario;
using Libreria.LogicaAplicacion.ICasosUso.ICUUsuario;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaAplicacion.CasosUso.CUUsuario
{
    public class CULogin : ICULogin
    {
        private IRepositorioUsuario _repoUsuario;

        public CULogin(IRepositorioUsuario repoUsuario)
        {
            _repoUsuario = repoUsuario;
        }

        public DTOUsuario VerificarDatosParaLogin(DTOUsuario dto)
        {
            try
            {
                Usuario u = _repoUsuario.FindByEmail(dto.Email);

                bool coincideElPassword = Utilidades.Crypto.VerifyPasswordConBcrypt(dto.Password, u.Password);

                if (coincideElPassword)
                {
                    DTOUsuario ret = new DTOUsuario();
                    ret.Id = u.Id;
                    ret.Rol = u.Rol.ToString();
                    return ret;
                }
                else
                {

                    throw new Exception("Error de credenciales");
                    //TODO aca debo arrojar una exception propia
                }
            }
            catch (Exception e)
            {

                throw e;
            }
         

        }
    }
}
