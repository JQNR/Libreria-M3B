
using Libreria.DTOs.DTOs.DTOsUsuario;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.Enumerados.UsuarioEnums;
using Libreria.LogicaNegocio.VO.Compartidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.Mappers
{
    public class MapperUsuario
    {
        public static Usuario ToUsuario(DTOAltaUsuario dto) {

            var r = Roles.Empleado;

            if (dto.Rol.Equals(2)) {
                r = Roles.Cliente;
            }

            string passHashed = Utilidades.Crypto.HashPasswordConBcrypt(dto.Password, 12);


            Usuario ret = new Usuario(new NombreCompleto(dto.Nombre,dto.Apellido),dto.Cargo,dto.Email,passHashed,r);

            return ret;
        
        }
    }
}
