using Libreria.LogicaNegocio.CustomExceptions.EmpleadoExceptions;
using Libreria.LogicaNegocio.Enumerados.UsuarioEnums;
using Libreria.LogicaNegocio.VO.Compartidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Usuario
    {
   

        public int Id { get; set; }
        /*La property Nombre es un VO que se utiliza en Empleado y en Autor. Por este motivo deberá configurarse OwnsOne en el onmodelCreating
         Si este VO se usara únicamente aquí, no hace falta aclarar nada al contexto.
         */
        public NombreCompleto NombreCompleto { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Rol { get; set; }
        public bool Estado { get; set; }


        public Usuario(NombreCompleto nombreCompleto, string cargo, string email, string password, Roles rol)
        {
            NombreCompleto = nombreCompleto;
            Cargo = cargo;
            Email = email;
            Password = password;
            Estado = true;
            Rol = rol;

            NombreCompleto.Validar();
            if (!email.Contains('@')) {

                throw new EmailNoValidoException("EL email no tiene arroba");
            }
        }

        public Usuario()
        {
            Estado = true;
        }


    }
}
