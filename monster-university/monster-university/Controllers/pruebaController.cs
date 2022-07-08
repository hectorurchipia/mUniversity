using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace monster_university.Controllers
{
    public class PruebaController : Controller
    {
        // GET: prueba
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Hola(string para)
        {
            return View();
        }

    }
}