using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DTOs.DTOs.DTOsPais
{
    public class DTOAltaPais
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Codigo { get; set; }
        public int? LogueadoId { get; set; }
    }
}
