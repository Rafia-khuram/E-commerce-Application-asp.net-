using ShoppingApplication.BAL;
using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View(new ProductBAL().GetProducts());
        }
        public ActionResult Detail(int Id)
        {
            return View(new ProductBAL().GetProduct(Id));
        }

        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}