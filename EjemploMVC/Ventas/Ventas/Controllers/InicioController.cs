using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ventas.Controllers
{
    public class InicioController : Controller
    {
        public ActionResult PaginaPrincipal()
        {
            return View("PaginaPrincipal");
        }
    }
}
