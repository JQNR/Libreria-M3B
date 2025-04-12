
using Libreria.DTOs.DTOs.DTOsUsuario;
using Libreria.LogicaAplicacion.ICasosUso.ICUEmpleado;
using Libreria.LogicaAplicacion.ICasosUso.ICUUsuario;
using Libreria.WebApp.Filtros;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    
    public class UsuarioController : Controller
    {
        private ICUAltaUsuario _CUAltaEmpleado;
        private ICULogin _CULogin;


        public UsuarioController(ICUAltaUsuario CUAltaEmpleado,ICULogin culogin)
        {
            _CUAltaEmpleado = CUAltaEmpleado;
            _CULogin = culogin;
        }
        public IActionResult Index()
        {

            return View();
        }

        [LogueadoAuthorize]
        [EmpleadoAuthorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DTOAltaUsuario dto)
        {
            try
            {
                int? lid = HttpContext.Session.GetInt32("LogueadoId");
                dto.LogueadoId = lid;

                _CUAltaEmpleado.AltaEmpleado(dto);
                ViewBag.msg = "Alta correcta";
            }
            catch (Exception e)
            {

                ViewBag.msg = e.Message;
            }
            return View();
        }


        public IActionResult AccesoDenegado() { 
        return View();
        }


        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(DTOUsuario dto)
        {
            try
            {
                DTOUsuario b = _CULogin.VerificarDatosParaLogin(dto);
                HttpContext.Session.SetInt32("LogueadoId", (int)b.Id);
                HttpContext.Session.SetString("LogueadoRol", b.Rol);
            }
            catch (Exception e)
            {

                throw;
            }
            return View();
        }
    }
}
