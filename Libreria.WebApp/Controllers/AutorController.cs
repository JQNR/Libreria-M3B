using Libreria.DTOs.DTOs.DTOsPais;
using Libreria.LogicaAplicacion.ICasosUso.ICUAltaAutor;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Libreria.WebApp.Controllers
{
    public class AutorController : Controller
    {
        private ICUAltaAutor _cUAltaAutor;
        private ICUObtenerPaises _cuObtenerPaises;

        public AutorController(ICUAltaAutor CualtaAutor, ICUObtenerPaises cuObtenerPaises)
        {
            _cUAltaAutor = CualtaAutor;
            _cuObtenerPaises = cuObtenerPaises;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() {

            List<DTOPais> paises = _cuObtenerPaises.ObtenerPaises();
            AltaAutorViewModel model = new AltaAutorViewModel();

            foreach (var dtop in paises) {
                SelectListItem sitem = new SelectListItem();
                sitem.Text = dtop.Nombre;
                sitem.Value = dtop.Id.ToString();
                model.Paises.Add(sitem);   
            }

          

           return View(model);
        }

        [HttpPost]
        public IActionResult Create(AltaAutorViewModel vm) {

            try
            {
                _cUAltaAutor.AltaAutor(vm.dto);
                return RedirectToAction("Index","Autor");
            }
            catch (Exception)
            {

              
            }
            
            return View();

        
        }
    }
}
