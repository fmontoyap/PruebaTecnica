using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTecnica.Controllers
{
    public class TrianguloController : Controller
    {

        [HttpGet]
        public ActionResult Area()
        {
            Triangulo triangulo = new Triangulo();
            return View(triangulo);
        }
	}
}