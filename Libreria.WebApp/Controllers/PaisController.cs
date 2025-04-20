using Libreria.DTOs.DTOs.DTOsPais;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.WebApp.Controllers
{
    public class PaisController : Controller
    {

        private ICUAltaPais _CuAltaPais;
        private ICUObtenerPaises _CuObtenerPaises;

        public PaisController(ICUAltaPais CuAltaPais, ICUObtenerPaises cuObtenerPaises)
        {
            _CuAltaPais = CuAltaPais;
            _CuObtenerPaises = cuObtenerPaises;
        }
        public IActionResult Index()
        {
            return View(_CuObtenerPaises.ObtenerPaises());
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(DTOAltaPais dto)
        {
            try
            {
                dto.LogueadoId = 20;
                _CuAltaPais.AltaPais(dto);
            }
            catch (Exception e)
            {


            }

            return View();
        }


        public IActionResult Edit(int id) { 
           return View();
        }

        [HttpPost]
        public IActionResult Edit(DTOAltaPais dto)
        {
            return View();
        }
    }
}

