﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BOL
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role{ get; set; }
        public string AccessToken { get; set; }
    }
}
