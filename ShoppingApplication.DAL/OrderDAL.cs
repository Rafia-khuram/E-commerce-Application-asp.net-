using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class OrderDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();

        public void AddOrderStatus(OrderStatus orderStatus)
        {
            db.OrderStatuses.Add(orderStatus);
            db.SaveChanges();
        }
        public OrderStatus GetOrderStatus(int Id)
        {
            return db.OrderStatuses.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditOrderStatus(OrderStatus orderStatus)
        {
            var DbOrderStatus = db.OrderStatuses.Where(x => x.Id == orderStatus.Id).FirstOrDefault();
            if (DbOrderStatus != null)
            {
                if (!String.IsNullOrEmpty(orderStatus.Name))
                {
                    DbOrderStatus.Name = orderStatus.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteOrderStatus(int Id)
        {
            db.OrderStatuses.Remove(db.OrderStatuses.Find(Id));
            db.SaveChanges();
        }
        public List<OrderStatus> GetOrderStatuses()
        {
            return db.OrderStatuses.ToList();
        }
        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }

        public void AddOrder(Order order)
        {
             db.Orders.Add(order);
            db.SaveChanges();
        }

        public List<Order> GetBuyerProducts(int buyerId)
        {
            return db.Orders.Where(x => x.BuyerId == buyerId).ToList();
        }

    }
}
