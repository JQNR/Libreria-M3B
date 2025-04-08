using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.VO.Compartidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.DTOs.DTOsAutor
{
    public class DTOAutor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }

        public DTOAutor(int id, string nombre, string apellido, string nacionalidad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        public DTOAutor()
        {
            
        }
    }
}
