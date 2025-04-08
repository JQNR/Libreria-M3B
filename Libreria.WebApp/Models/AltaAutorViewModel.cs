using Libreria.DTOs.DTOs.DTOsAutor;
using Libreria.DTOs.DTOs.DTOsPais;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;

namespace Libreria.WebApp.Models
{
    public class AltaAutorViewModel
    {
        public DTOAltaAutor dto{ get; set; }

        public List<SelectListItem> Paises { get; set; } = new List<SelectListItem>();


    }
}
