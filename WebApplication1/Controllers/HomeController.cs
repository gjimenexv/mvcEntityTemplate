using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult file()
        //{
            //public FileResult file()
            {
                var ruta = Server.MapPath("../App_Data/COBIT-2019-Framework-Introduction-and-Methodology_res_eng_1118.pdf");
                ViewBag.Roncar = ruta;
                return File(ruta, "application/pdf", "Transformers.pdf");
                //return View();
            }
        public ContentResult Content()
        {
            ViewBag.Message = "Your contact page.";
            return Content("Felipe");
            //return View();
        }

        public ContentResult Contenthtml()
        {
            ViewBag.Message = "Your contact page.";
            return Content("<b>Felipe</b>");
            //return View();
        }

        public ActionResult redirect()
        {
            //return Redirect("http://google.com");
            //return RedirectToAction("Index", "Orders");
            return RedirectToRoute("Guillermo");
            //return View();
        }
        public HttpStatusCodeResult codeResult()
        {
            //return new HttpStatusCodeResult(401,"Internal Error");
            return new HttpStatusCodeResult(301, "Warning Hola");
        }

        public ActionResult queryString(string nombre)
        {
            ViewBag.Message = "My name is --> " + nombre;
            return View();
        }

        public ActionResult queryString2(string nombre, int edad)
        {
            ViewBag.Message = "My name is --> " + nombre + " mi edad:" + edad.ToString();
            return View();
        }

        public ActionResult queryString3(string nombre, int? edad)
        {
            ViewBag.Message = "My name is --> " + nombre + " mi edad:" + (edad.HasValue ? edad.ToString() : String.Empty);
            //ViewBag.Message = "My name is --> " + nombre + " mi edad:";
            return View();
        }

    }
}