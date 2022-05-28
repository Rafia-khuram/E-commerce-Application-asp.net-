using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApplication.BOL
{
    public class Address
    {
        public int Id { get; set; }
        public string CompleteAddress { get; set; }

        public virtual User User { get; set; }
        public int UserId { get; set; }

        public virtual City City { get; set; }
        public int CityId { get; set; }
    }
}