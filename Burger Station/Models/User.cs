﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burger_Station.Models
{
    public class User
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public DateTime Birthday { get; set; }

        public String PhoneNumber { get; set; }

        //public enum MembershipType { get; set; }

        public Branch favBranch { get; set; }

        public ICollection<Order> listOrders { get; set; }

        public ICollection<Comment> listComments { get; set; }



    }
}
