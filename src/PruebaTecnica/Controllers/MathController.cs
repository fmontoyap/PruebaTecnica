﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTecnica.Controllers
{
    public class MathController : Controller
    {

        public ActionResult PerimetroCuadrado(double lado)
        {
            return Json(4*lado, JsonRequestBehavior.AllowGet);


            //throw new NotImplementedException();
        }
    }
}