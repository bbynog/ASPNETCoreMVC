using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return new ContentResult(){ Content = "Chico Bento", ContentType = "text/json" };

            return View();           
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Usuario = new Usuario();
            return View();
        }

        [HttpPost ]
        public ActionResult Login([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "do.not.reply.this.x@gmail.com" && usuario.Senha == "Teste12345")
                {
                    /* Add Session
                     * HttpContext.Session.SetString("Login", "true");
                     * HttpContext.Session.SetInt32("UserID", 1);
                     * HttpContext.Session.SetString("Login", Serialize Object > String(NewtonSoft));
                     * 
                     * Read Session
                     * string login = HttpContext.Session.GetString("Login");
                     */
                    HttpContext.Session.SetString("Login", "true");

                    ViewBag.Usuario = new Usuario();
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Usuario = usuario;
                    ViewBag.Mensagem = "Os dados informados são inválidos";
                    return View();
                }
            }
            else
            {
                ViewBag.Usuario = usuario;
                ViewBag.Mensagem = "Os dados informados são inválidos";
                return View();
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
