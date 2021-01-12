using Microsoft.AspNetCore.Mvc;
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
    }
}
