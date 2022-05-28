using ShoppingApplication.BAL;
using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.WebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        // ---------------------------  Admin Login ----------------------------------
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(string email,string password)
        {
    
            var user = new AccountBAL().GetUserInfo(email, password);
            Response.Cookies["user-access-token"].Value = user.AccessToken;
            Response.Cookies["user-access-token"].Expires = DateTime.Now.AddDays(1);
       

            if (user.Role.Equals("Admin"))
            {
                return Redirect("/Admin/Index");
            }
            else
            {
                ViewBag.Error = "Email or password is incorrect or you do not have permission to access! Try again..";
                return View();
            }
        }

        // ------------------- user Login-------------------------------
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email,string password)
        {
        
            var user = new AccountBAL().GetUserInfo(email, password);
                Response.Cookies["user-access-token"].Value = user.AccessToken;
                Response.Cookies["user-access-token"].Expires = DateTime.Now.AddDays(1);
                if (user.Role.Equals("Buyer"))
                {
                    return Redirect("/Buyer/Index");
                }

                else if (user.Role.Equals("Seller"))
                {
                    return Redirect("/Seller/Index");
                }
                else
                {
                    ViewBag.Error = "You do not have permission to access!";
                    return View();
                }
      

        }

    public ActionResult Registeration()
    {
            ViewBag.Roles = new UserBAL().GetRoles();
            return View();
    }
    [HttpPost]
    public ActionResult Registeration(User user)
    {
            new AccountBAL().Register(user);
         

                Response.Cookies["user-access-token"].Value = user.AccessToken;
                Response.Cookies["user-access-token"].Expires = DateTime.Now.AddDays(1);
                if (user.RoleId == 2)
                {
                    return Redirect("/Buyer/Index");
                }
                else if(user.RoleId==3)
                {
                    return Redirect("/Seller/Index");
                }

            
            return Redirect("~/Home/Index");
        }
}

}