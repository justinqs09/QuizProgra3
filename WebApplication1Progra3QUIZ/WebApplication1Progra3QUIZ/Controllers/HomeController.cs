using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1Progra3QUIZ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bienvenido al Registro de Viajes.";

            return View();
        }  

        public ActionResult Contact()
        {
            ViewBag.Message = "Puedes encontrarnos en:.";
            ViewBag.Message = "https://agenciaviajesdisney.com/.";

            return View();
        }
    }
}