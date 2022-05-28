using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class UserDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public void AddRole(Role role)
        {
            db.Roles.Add(role);
            db.SaveChanges();
        }
        public Role GetRole(int Id)
        {
            return db.Roles.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditRole(Role role)
        {
            var DbRole = db.Roles.Where(x => x.Id == role.Id).FirstOrDefault();
            if (DbRole != null)
            {
                if (!String.IsNullOrEmpty(role.Name))
                {
                    DbRole.Name = role.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteRole(int Id)
        {
            db.Roles.Remove(db.Roles.Find(Id));
            db.SaveChanges();
        }
        public List<Role> GetRoles()
        {
            return db.Roles.ToList();
        }
        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public User GetUser(int Id)
        {
            return db.Users.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditUser(User user)
        {
            var DbUser = db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (DbUser != null)
            {
                if (!String.IsNullOrEmpty(user.UserName))
                {
                    DbUser.UserName = user.UserName;
                }
                if (!String.IsNullOrEmpty(user.Email))
                {
                    DbUser.Email = user.Email;
                }
                if (!String.IsNullOrEmpty(user.PhoneNumber))
                {
                    DbUser.PhoneNumber = user.PhoneNumber;
                }
                if (!String.IsNullOrEmpty(user.RoleId.ToString()))
                {
                    DbUser.RoleId = user.RoleId;
                }
                if (!String.IsNullOrEmpty(user.Password))
                {
                    DbUser.Password = user.Password;
                }
            }
            db.SaveChanges();
        }
        public void DeleteUser(int Id)
        {
            db.Users.Remove(db.Users.Find(Id));
            db.SaveChanges();
        }
        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }
        public List<User> GetBuyers()
        {
            return db.Users.Where(x => x.RoleId == 2).ToList();
        }
        public List<User> GetSellers()
        {
            return db.Users.Where(x => x.RoleId == 3).ToList();
        }


       
    }
}
