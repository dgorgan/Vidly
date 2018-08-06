using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("About/{id?}")]
        public ActionResult About(int? id)
        {
            if (id != null)
            {
                ViewBag.Message = "Your application description page and id: " + id;
            } else
            {
                ViewBag.Message = "Your application description page without id";
            }

            return View();
        }    

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}