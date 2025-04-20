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
        private ICUObtenerGenero _CUObtenerGenero;
        private ICUActualizarGenero _CUActualizarGenero;
        
        

        public GeneroController(ICUAltaGenero CuAltaGenero, 
            ICUListarGeneros CuListarGeneros, 
            ICUObtenerGenero cUObtenerGenero,
            ICUActualizarGenero CUActualizarGenero)
        {
            _CuAltaGenero = CuAltaGenero;
            _CuListarGeneros = CuListarGeneros;
            _CUObtenerGenero = cUObtenerGenero;
            _CUActualizarGenero = CUActualizarGenero;
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

        public IActionResult Edit(int id) { 
        
             //salir a buscar el genero con este id
             DTOGenero model = _CUObtenerGenero.ObtenerGenero(id);
             return View(model);
        }


        [HttpPost]
        public IActionResult Edit(DTOGenero dto)
        {
            try
            {
                dto.LogueadoId = HttpContext.Session.GetInt32("LogueadoId");
                _CUActualizarGenero.ActualizarGenero(dto);
            }
            catch (EdadMinimaException e)
            {
                ViewBag.error = e.Message;
               
            }
            catch (NombreGeneroException e)
            {

                ViewBag.error = e.Message;
            }
            return View();
        }
    }
}
