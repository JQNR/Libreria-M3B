using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.DTOs.DTOsAutor
{
    public class DTOAltaAutor
    {

        [Required]
        public string Nombre { get; set; }

        [Required]

        public string Apellido { get; set; }
        public int PaisId { get; set; }

        public DTOAltaAutor(string nombre, string apellido, int paisId)
        {
            Nombre = nombre;
            Apellido = apellido;
            PaisId = paisId;
        }

        public DTOAltaAutor()
        {
            
        }
    }
}
