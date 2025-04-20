using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.DTOs.DTOsGenero
{
    public class DTOAltaGenero
    {
        [Required]

        [StringLength(100, MinimumLength = 3, ErrorMessage = "La longitud debe estar entre 3 y 100 caracteres")]

        public string Nombre { get; set; }

        // [Display(Name = "Edad mínima")]
        public int EdadMinima { get; set; }
    }
}
