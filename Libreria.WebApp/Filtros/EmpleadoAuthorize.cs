using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libreria.WebApp.Filtros
{
    public class EmpleadoAuthorize : ActionFilterAttribute
    {
     
            public override void OnActionExecuting(ActionExecutingContext context)
            {
                // Verifica si la sesión contiene un usuario con rol de administrador
                var userRole = context.HttpContext.Session.GetString("LogueadoRol");
                if (userRole != "Empleado")
                {
                    // Si no hay un rol de administrador, redirige al login o muestra un error
                    context.Result = new RedirectToActionResult("AccesoDenegado", "Usuario",null);
                }
                base.OnActionExecuting(context);
            }
        }

}
