using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.Services.SouthAmerica.MessageHandlers.DataAccess;
using com.iex.orders.getorders;
using com.iex.orders.order;
using com.iex.orders.saveuser;

namespace InformationExchange.Services.SouthAmerica.MessageHandlers
{
    public class OrderInformationService
    {
        public OrderResponse GetOrders(OrderRequest request)
        {
            var response = new OrderResponse { Orders = new ArrayOfOrders() };

            var context = new OrderManagementSouthAmericaEntities();

            var user = context.Users.FirstOrDefault(u => u.UserName == request.UserName);

            if (user == null) return response;

            var orders = context.Orders.Where(order => order.UserId == user.Id).ToList();
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

		public int SaveUser(UserRequest userRequest)
		{
			var context = new OrderManagementSouthAmericaEntities();

			var user = new User()
			{
				UserName = userRequest.UserName
			};

			context.Users.Add(user);

			return context.SaveChanges();
		}
    }
}
