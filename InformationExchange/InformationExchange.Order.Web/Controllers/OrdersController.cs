using com.iex.orders.getorders;
using InformationExchange.Order.Web.Models;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using InformationExchange.Order.Web.Extensions;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using InformationExchange.Order.Web.Messaging;

namespace InformationExchange.Order.Web.Controllers
{
	[Authorize]
	public class OrdersController : Controller
	{

		public OrdersController()
			: this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
		{
		}

		 public OrdersController(UserManager<ApplicationUser> userManager)
		{
			UserManager = userManager;
		}

		public UserManager<ApplicationUser> UserManager { get; private set; }
		
		// GET: /Order/
		public async Task<ActionResult> Index()
		{
			var user = await UserManager.FindByNameAsync(User.Identity.GetUserName());

			var request = new OrderRequest()
			{
				UserName  = user.UserName
			};

			var message = MessagingService.CreateGetOrderMessage(request, user.Region);

			var messagingService = new MessagingService();

			var orderResponse = messagingService.SendAndRespond<OrderResponse>(message);
			
			List<OrderView> orders = new List<OrderView>();

			orderResponse.Orders.ForEach(order =>
			{
				OrderView ov = new OrderView()
				{
					Id = order.Id,
					Name = order.Name,
					Items = order.Items,
					Value = order.Value,
					Country = order.Country,
					Region = order.Region
				};

				orders.Add(ov);
			});

			

			return View(orders);
		}
	}
}