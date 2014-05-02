using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.Services.SouthAmerica.MessageHandlers.DataAccess;
using com.iex.orders.getorders;
using com.iex.orders.order;

namespace InformationExchange.Services.SouthAmerica.MessageHandlers
{
    public class OrderInformationService
    {
        public OrderResponse GetOrders(OrderRequest request)
        {
            var response = new OrderResponse { Orders = new ArrayOfOrders() };

            var context = new OrderManagementSouthAmericaEntities();
            var orders = context.Orders.ToList();
            orders.ForEach(order =>
            {
                var responseOrder = new com.iex.orders.order.Order
                {
                    Id = order.Id.ToString(),
                    Name = order.Name,
                    Items = order.Items,
                    Value = order.Value,
                    Country =order.Country_Code,
                    Region = "South America"
                };

                response.Orders.Add(responseOrder);
            });

            return response;
        }
    }
}
