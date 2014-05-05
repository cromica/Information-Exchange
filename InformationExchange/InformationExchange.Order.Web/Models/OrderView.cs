using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationExchange.Order.Web.Models
{
    public class OrderView
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public long Items { get; set; }

        public decimal Value { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }
    }
}