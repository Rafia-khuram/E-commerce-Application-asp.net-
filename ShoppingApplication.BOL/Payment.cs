using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApplication.BOL
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime SubmittedOn { get; set; }

        public virtual Order Order { get; set; }
        public int OrderId { get; set; }

        public virtual PaymentStatus PaymentStatus { get; set; }
        public int PaymentStatusId { get; set; }

    }
}