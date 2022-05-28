using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class AccountDAL
    {
    
        private readonly ShoppingContext db = new ShoppingContext();
        public bool CheckAdmin(string email ,string password)
        {
            return db.Users.Where(x => x.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase) && x.Password.Equals(password) && x.RoleId == 1).Any();

        }

        public User GetUser(string email,string password)
        {
            return db.Users.Where(x => x.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase) && x.Password.Equals(password) ).FirstOrDefault();

        }

        public User GetUser(int id)
        {
            return db.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public UserInfo GetUserInfo(string email, string password)
        {
            return db.Users.Where(x => x.Email.Equals(email, StringComparison.InvariantCultureIgnoreCase) && x.Password.Equals(password)).Select(x => new UserInfo { Id = x.Id, Name = x.UserName, Role = x.Role.Name,AccessToken=x.AccessToken }).FirstOrDefault();

        }
        public int GetUserRole(string AccessToken)
        {
            return db.Users.Where(x => x.AccessToken.Equals(AccessToken)).Select(x=> x.RoleId ).FirstOrDefault();

        }
        public int GetUserId(string AccessToken)
        {
            return db.Users.Where(x => x.AccessToken.Equals(AccessToken)).Select(x => x.Id).FirstOrDefault();

        }

        public string GetProductName(int id)
        {
            return db.Products.Where(x => x.Id == id).Select(x => x.Name).FirstOrDefault();
        }
    }
}
