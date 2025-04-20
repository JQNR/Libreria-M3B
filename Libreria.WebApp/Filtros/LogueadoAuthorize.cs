using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

namespace Libreria.WebApp.Filtros
{
    public class LogueadoAuthorize:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Verifica si la sesión contiene un usuario con rol de administrador
            int? logueadoId = context.HttpContext.Session.GetInt32("LogueadoId");
            if (logueadoId == null)
            {
                // Si no hay un rol de administrador, redirige al login o muestra un error
                context.Result = new RedirectToActionResult("Login", "Usuario", null);
            }
            base.OnActionExecuting(context);
        }
    }
}
