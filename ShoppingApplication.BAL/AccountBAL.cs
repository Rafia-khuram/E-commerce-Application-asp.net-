using ShoppingApplication.BOL;
using ShoppingApplication.DAL;
using ShoppingApplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
   public  class AccountBAL
    {
        public bool CheckAdmin(string email, string password)
        {
            return new AccountDAL().CheckAdmin(email, password);
        }

        public User GetUser(string email, string password)
        {
            return new AccountDAL().GetUser(email, password);

        }

        public User GetUser(int id)
        {
            return new AccountDAL().GetUser(id);
        }

        public void Register(User user)
        {
            user.AccessToken = RandomHandler.GenerateAccessToken();
            new AccountDAL().Register(user);
        }

        public UserInfo GetUserInfo(string email, string password)
        {
            return new AccountDAL().GetUserInfo(email, password);

        }
        public int GetUserRole(string AccessToken)
        {
            return new AccountDAL().GetUserRole(AccessToken);
        }

        public int GetUserId(string AccessToken)
        {
            return new AccountDAL().GetUserId(AccessToken);
        }
        public string GetProductName(int id)
        {
            return new AccountDAL().GetProductName(id);
        }

    }

}
