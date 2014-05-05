using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationExchange.Order.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Order Management description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If you want to get in touch with me here is some information.";

            return View();
        }
    }
}