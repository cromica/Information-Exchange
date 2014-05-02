using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.iex.orders.order;

namespace InformationExchange.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Id = "100";
            o.Name = "Test";
            o.Items = 10;
            o.Value = 12.2m;
            o.Country = "France";
            o.Region = "Europe";

        }
    }
}
