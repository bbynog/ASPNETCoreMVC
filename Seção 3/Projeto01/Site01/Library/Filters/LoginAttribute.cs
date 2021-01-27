using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {            
            // Verificar se a session existe
            if (context.HttpContext.Session.GetString("Login") == null )
            {
                // Verificar se existe controlador a seguir e alocar TempData de Erro.
                if (context.Controller != null)
                {
                    Controller controlador = context.Controller as Controller;
                    controlador.TempData["MensagemErro"] = "É necessário realizar o login";
                }
                //Redirecionar
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }

        }

    }
}
