using ShoppingApplication.BAL;
using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.WebUI.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        public ActionResult Index()
        {
            if (new CommonController().IsAdmin(Request))
            {
                return View();
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddRole()
        {
            if (new CommonController().IsAdmin(Request))
                return View();
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddRole(Role role)
        {

            if (new CommonController().IsAdmin(Request))
            {
            new UserBAL().AddRole(role);
            return RedirectToAction("Roles");

            }
            else
               
                return Redirect("/Home/Index");
        }
        public ActionResult EditRole(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
                return View(new UserBAL().GetRole(Id));
            }
            else
                return Redirect("/Home/Index");
            
        }
        [HttpPost]
        public ActionResult EditRole(Role role)
        {

            if (new CommonController().IsAdmin(Request))
            {
                new UserBAL().EditRole(role);
                return RedirectToAction("Roles");
            }
            else
                return Redirect("/Home/Index");
  
        }
        public ActionResult DeleteRole(int Id)
        {

            if (new CommonController().IsAdmin(Request))
            {
                new UserBAL().DeleteRole(Id);
                return RedirectToAction("Roles");
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Roles()
        {
            if (new CommonController().IsAdmin(Request))
            { 
                return View(new UserBAL().GetRoles());
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddUser()
        {
            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Roles = new UserBAL().GetRoles();
            return View();

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult Adduser(User user)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new UserBAL().AddUser(user);
            return RedirectToAction("Users");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult EditUser(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Roles = new UserBAL().GetRoles();
            return View(new UserBAL().GetUser(Id));

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditUser(User user)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new UserBAL().EditUser(user);
            return RedirectToAction("Users");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeleteUser(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new UserBAL().DeleteUser(Id);
            return RedirectToAction("Users");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Users()
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new UserBAL().GetUsers());
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddCity()
        {
            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Countries = new AddressBAL().GetCountries();
            return View();
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddCity(City city)
        {
            if (new CommonController().IsAdmin(Request))
            {

            new AddressBAL().AddCity(city);
            return RedirectToAction("Cities");
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult EditCity(int Id)
        {

            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Countries = new AddressBAL().GetCountries();
            return View(new AddressBAL().GetCity(Id));

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditCity(City city)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new AddressBAL().EditCity(city);
            return RedirectToAction("Cities");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeleteCity(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new AddressBAL().DeleteCity(Id);
            return RedirectToAction("Cities");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Cities()
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new AddressBAL().GetCities());
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddCountry()
        {
            if (new CommonController().IsAdmin(Request))
            {
               return View();
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddCountry(Country country)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new AddressBAL().AddCountry(country);
            return RedirectToAction("Countries");

            }
            else
                return Redirect("/Home/Index");
        }

        public ActionResult EditCountry(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View(new AddressBAL().GetCountry(Id));
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditCountry(Country country)
        {
            if (new CommonController().IsAdmin(Request))
            {

            new AddressBAL().EditCountry(country);
            return RedirectToAction("Countries");
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeleteCountry(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new AddressBAL().DeleteCountry(Id);
            return RedirectToAction("Countries");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Countries()
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new AddressBAL().GetCountries());
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Addresses()
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View(new AddressBAL().GetAddresses());

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddProductStatus()
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View();

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddProductStatus(ProductStatus productStatus)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new ProductBAL().AddProudctStatus(productStatus);
            return RedirectToAction("ProductStatuses");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult EditProductStatus(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new ProductBAL().GetProductStatus(Id));
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditProductStatus(ProductStatus productStatus)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new ProductBAL().EditProductStatus(productStatus);
            return RedirectToAction("ProductStatuses");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeleteProductStatus(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new ProductBAL().DeleteProductStatus(Id);
            return RedirectToAction("ProductStatuses");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult ProductStatuses()
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new ProductBAL().GetProductStatuses());
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddProduct()
        {
            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Sellers = new UserBAL().GetSellers();
            ViewBag.ProductStatuses = new ProductBAL().GetProductStatuses();
            return View();

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new ProductBAL().AddProduct(product);
            return RedirectToAction("Products");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult EditProduct(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Sellers = new UserBAL().GetSellers();
            ViewBag.ProductStatuses = new ProductBAL().GetProductStatuses();
            return View(new ProductBAL().GetProduct(Id));

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new ProductBAL().EditProduct(product);
            return RedirectToAction("Products");
 
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeleteProduct(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new ProductBAL().DeleteProduct(Id);
            return RedirectToAction("Products");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Products()
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new ProductBAL().GetProducts());
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddOrderStatus()
        {
            if (new CommonController().IsAdmin(Request))
            {
               return View();
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddOrderStatus(OrderStatus orderStatus)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new OrderBAL().AddOrderStatus(orderStatus);
            return RedirectToAction("OrderStatuses");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult EditOrderStatus(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new OrderBAL().GetOrderStatus(Id));
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditOrderStatus(OrderStatus orderStatus)
        {
            if (new CommonController().IsAdmin(Request))
            {

            new OrderBAL().EditOrderStatus(orderStatus);
            return RedirectToAction("OrderStatuses");
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeleteOrderStatus(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new OrderBAL().DeleteOrderStatus(Id);
            return RedirectToAction("OrderStatuses");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult OrderStatuses()
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View(new OrderBAL().GetOrderStatuses());

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Orders()
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View(new OrderBAL().GetOrders());

            }
            else
                return Redirect("/Home/Index");
        }

        public ActionResult AddPaymentStatus()
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View();
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddPaymentStatus(PaymentStatus paymentStatus)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new PaymentBAL().AddPaymentStatus(paymentStatus);
            return RedirectToAction("PaymentStatuses");

            }
            else
                return Redirect("/Home/Index");


        }
        public ActionResult EditPaymentStatus(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {

            return View(new PaymentBAL().GetPaymentStatus(Id));
            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditPaymentStatus(PaymentStatus paymentStatus)
        {
            if (new CommonController().IsAdmin(Request))
            {

            new PaymentBAL().EditPaymentStatus(paymentStatus);
            return RedirectToAction("PaymentStatuses");
            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeletePaymentStatus(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new PaymentBAL().DeletePaymentStatus(Id);
            return RedirectToAction("PaymentStatuses");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult PaymentStatuses()
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View(new PaymentBAL().GetPaymentStatuses());

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult AddPayment()
        {
            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Orders = new OrderBAL().GetOrders();
            ViewBag.PaymentStatuses = new PaymentBAL().GetPaymentStatuses();
            return View();

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult AddPayment(Payment payment)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new PaymentBAL().AddPayment(payment);
            return RedirectToAction("Payments");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult EditPayment(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            ViewBag.Orders = new OrderBAL().GetOrders();
            ViewBag.PaymentStatuses = new PaymentBAL().GetPaymentStatuses();
            return View(new PaymentBAL().GetPayment(Id));

            }
            else
                return Redirect("/Home/Index");
        }
        [HttpPost]
        public ActionResult EditPayment(Payment payment)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new PaymentBAL().EditPayment(payment);
            return RedirectToAction("Payments");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult DeletePayment(int Id)
        {
            if (new CommonController().IsAdmin(Request))
            {
            new PaymentBAL().DeletePayment(Id);
            return RedirectToAction("Payments");

            }
            else
                return Redirect("/Home/Index");
        }
        public ActionResult Payments()
        {
            if (new CommonController().IsAdmin(Request))
            {
            return View(new PaymentBAL().GetPayments());

            }
            else
                return Redirect("/Home/Index");
        }

    }
}