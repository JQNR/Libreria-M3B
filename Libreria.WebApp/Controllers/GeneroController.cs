using Libreria.DTOs.DTOs.DTOsGenero;
using Libreria.LogicaAplicacion.CasosUso.CUGenero;
using Libreria.LogicaAplicacion.ICasosUso.ICUGenero;
using Libreria.LogicaNegocio.CustomExceptions.GeneroExceptions;
using Libreria.LogicaNegocio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class GeneroController : Controller
    {
        private ICUAltaGenero _CuAltaGenero;
        private ICUListarGeneros _CuListarGeneros;

        public GeneroController(ICUAltaGenero CuAltaGenero, ICUListarGeneros CuListarGeneros)
        {
           _CuAltaGenero = CuAltaGenero;
           _CuListarGeneros = CuListarGeneros;
        }
        public IActionResult Index()
        {
            return View(_CuListarGeneros.ListarGeneros());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DTOAltaGenero nuevo)
        {
            try
            {

                _CuAltaGenero.AltaGenero(nuevo);
                ViewBag.msg = "Alta correcta";

            }
            catch (NombreGeneroException e)
            {

                ViewBag.msg = e.Message;
            }
            catch (EdadMinimaException e)
            {

                ViewBag.msg = e.Message;
            }
            catch (Exception e) {

                ViewBag.msg = e.Message;
            }

            return View();
        }
    }
}
