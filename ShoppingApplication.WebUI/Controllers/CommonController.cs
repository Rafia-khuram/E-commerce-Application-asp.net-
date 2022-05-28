using ShoppingApplication.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApplication.WebUI.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public bool IsSeller(HttpRequestBase requestbase) 
        {
            if(requestbase.Cookies["user-access-token"]!= null)
            {
                var RoleId = new AccountBAL().GetUserRole((requestbase.Cookies["user-access-token"].Value));
                if (RoleId == 3)
                {
                    return true;
                }
            }
            return false;
        }


        //------------------------- get user id --------------------------------------

        public int GetUserId(HttpRequestBase requestbase)
        {
            if (requestbase.Cookies["user-access-token"] != null)
            {
               return new AccountBAL().GetUserId((requestbase.Cookies["user-access-token"].Value));
              
            }
            return 0;
        }



        public bool IsBuyer(HttpRequestBase requestbase)
        {
            if(requestbase.Cookies["user-access-token"]!= null)
            {
                var RoleId = new AccountBAL().GetUserRole((requestbase.Cookies["user-access-token"].Value));
                if (RoleId == 2)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsAdmin(HttpRequestBase requestbase)
        {
            if (requestbase.Cookies["user-access-token"]!= null)
            {
                var RoleId = new AccountBAL().GetUserRole(requestbase.Cookies["user-access-token"].Value);
                if (RoleId == 1)
                {
                    return true;
                }
            }
            return false;
        }
}
}