using ShoppingApplication.BAL;
using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.WebUI.Controllers
{
    public class BuyerController : Controller
    {
        // GET: Buyer
        public ActionResult Index()
        {
            if (new CommonController().IsBuyer(Request))
                return View();
            else
                return Redirect("/Home/Index");
        }


        public ActionResult Orders()
        {
            if (new CommonController().IsBuyer(Request))
            {
                return View(new OrderBAL().GetBuyerProducts(new CommonController().GetUserId(Request)));
            }
            else
                return Redirect("/Home/Index");
        }

      
        public ActionResult AddOrder(int id)
        {
            if (new CommonController().IsBuyer(Request))
            {

                Order order = new Order
                {
                    ProductId = id,
                    BuyerId = new CommonController().GetUserId(Request)
                };
                new OrderBAL().AddOrder(order);
                return RedirectToAction("Orders");
            }
           
                return Redirect("/Buyer/Index");
        }
    }
}

   