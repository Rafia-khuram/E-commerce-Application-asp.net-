﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApplication.BOL
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderedOn { get; set; }

        public virtual User Buyer { get; set; }
        public int BuyerId { get; set; }
        
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }  
        
        public virtual OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }

       

    }
}