using ShoppingApplication.BOL;
using ShoppingApplication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class UserBAL
    {
        public void AddRole(Role role)
        {
            new UserDAL().AddRole(role);
        }
        public Role GetRole(int Id)
        {
            return new UserDAL().GetRole(Id);
        }
        public void EditRole(Role role)
        {
            new UserDAL().EditRole(role);
        }
        public void DeleteRole(int Id)
        {
            new UserDAL().DeleteRole(Id);
        }
        public List<Role> GetRoles()
        {
            return new UserDAL().GetRoles();
        }
        public void AddUser(User user)
        {
            new UserDAL().AddUser(user);
        }
        public User GetUser(int Id)
        {
            return new UserDAL().GetUser(Id);
        }
        public void EditUser(User user)
        {
            new UserDAL().EditUser(user);
        }
        public void DeleteUser(int Id)
        {
            new UserDAL().DeleteUser(Id);
        }
        public List<User> GetUsers()
        {
            return new UserDAL().GetUsers();
        }
        public List<User> GetBuyers()
        {
            return new UserDAL().GetBuyers();
        }
        public List<User> GetSellers()
        {
            return new UserDAL().GetSellers();
        }

       
    }
}
