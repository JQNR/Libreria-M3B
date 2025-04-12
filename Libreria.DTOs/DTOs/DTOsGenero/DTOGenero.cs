using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.DTOs.DTOsGenero
{
    public class DTOGenero
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        [Display(Name = "Edad mínima")]


        public int EdadMinima { get; set; }
        public bool ATP { get; set; }
        public int? LogueadoId { get; set; }
    }
}
