using ShoppingApplication.BOL;
using ShoppingApplication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class OrderBAL
    {
        public void AddOrderStatus(OrderStatus orderStatus)
        {
            new OrderDAL().AddOrderStatus(orderStatus);
        }
        public OrderStatus GetOrderStatus(int Id)
        {
            return new OrderDAL().GetOrderStatus(Id);
        }
        public void EditOrderStatus(OrderStatus orderStatus)
        {
            new OrderDAL().EditOrderStatus(orderStatus);
        }
        public void DeleteOrderStatus(int Id)
        {
            new OrderDAL().DeleteOrderStatus(Id);
        }
        public List<OrderStatus> GetOrderStatuses()
        {
            return new OrderDAL().GetOrderStatuses();
        }
        public List<Order> GetOrders()
        {
            return new OrderDAL().GetOrders();
        }  
        
        public void AddOrder(Order order)
        {
            order.OrderedOn = DateTime.UtcNow.AddHours(5);
            order.OrderStatusId = 1;
            new OrderDAL().AddOrder(order);
            
        }

        public List<Order> GetBuyerProducts(int buyerId)
        {
            return new OrderDAL().GetBuyerProducts(buyerId);
        }

    }
}
