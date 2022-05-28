using ShoppingApplication.BAL;
using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.WebUI.Controllers
{
    public class SellerController : Controller
    {
        // GET: Seller
        public ActionResult Index()
        {
            if (new CommonController().IsSeller(Request))
                return View();
            else
                return Redirect("/Home/Index"); 
        }

        public ActionResult Products()
        {
            if (new CommonController().IsSeller(Request))
            {
                return View(new ProductBAL().GetSellerProducts(new CommonController().GetUserId(Request)));
            }
            else
                return Redirect("/Home/Index");
        }

        public ActionResult AddProduct()
        {
            if (new CommonController().IsSeller(Request))
            {
                ViewBag.ProductStatuses = new ProductBAL().GetProductStatuses();
                return View();

            }
            else
                return Redirect("/Home/Index");
        }
   
        public ActionResult AddProduct(Product product)
        {
            if (new CommonController().IsSeller(Request))
            {
               int UserId= new CommonController().GetUserId(Request);
                if (UserId != 0)
                {
                    product.SellerId = UserId;
                    new ProductBAL().AddProduct(product);
                  
                }
                return RedirectToAction("Products");
            }
            else
                return Redirect("/Seller/Index");
        }
    }
}