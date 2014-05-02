using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.Services.Europe.MessageHandlers.DataAccess;
using com.iex.orders.getorders;
using com.iex.orders.order;

namespace InformationExchange.Services.Europe.MessageHandlers
{
    public class OrderInformationService
    {
        public OrderResponse GetOrders(OrderRequest request)
        {
            var response = new OrderResponse {Orders = new ArrayOfOrders()};

            var context = new OrderManagementEuropeEntities();
            var orders = context.Orders.ToList();
            orders.ForEach(order =>
                {
                    var responseOrder = new com.iex.orders.order.Order
                        {
                            Id = order.Id.ToString(CultureInfo.InvariantCulture),
                            Name = order.Name,
                            Items = order.Items,
                            Value = order.Value,
                            Country = GetCountryIsoCode(order.Country),
                            Region = "Europe"
                        };

                    response.Orders.Add(responseOrder);
                });

            return response;
        }

        private string GetCountryIsoCode(string country)
        {
            switch (country)
            {
                case "Austria":
                    return "AUT";
                case "France":
                    return "FRA";
                case "Germany":
                    return "DEU";
                case "Italy":
                    return "ITA";
                case "Netherland":
                    return "NLD";
                case "United Kingdom":
                    return "GBR";
            }
            return string.Empty;
        }
    }
}
