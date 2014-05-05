using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using InformationExchange.Order.Web.Extensions;
using com.iex.orders.getorders;
using com.iex.orders.saveuser;

namespace InformationExchange.Order.Web.Messaging
{
	public class MessagingService
	{
		const string Topic = "Orders";

		private NamespaceManager _namespaceMgr;

		public MessagingService()
		{
			var connString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");

			_namespaceMgr = NamespaceManager.CreateFromConnectionString(connString);
		}

		public static BrokeredMessage CreateGetOrderMessage(OrderRequest request, string region)
		{
			var bMessage = new BrokeredMessage(request.ToJsonStream());
			bMessage.Properties.Add("region", region);
			bMessage.Label = "urn://com.iex.orders.GetOrders#OrderRequest";
			bMessage.ContentType = "text/json";

			return bMessage;
		}

		public static BrokeredMessage CreateSaveUserMessage(UserRequest request, string region)
		{
			var bMessage = new BrokeredMessage(request.ToJsonStream());
			bMessage.Properties.Add("region", region);
			bMessage.Label = "urn://com.iex.orders.SaveUser#UserRequest";
			bMessage.ContentType = "text/json";

			return bMessage;
		}

		public T SendAndRespond<T>(BrokeredMessage requestMessage)
		{
			var replyTo = Guid.NewGuid().ToString().Substring(0, 6);
			requestMessage.ReplyTo = replyTo;

			_namespaceMgr.CreateQueue(replyTo);

			var replyQueue = QueueClient.Create(replyTo);

			Send(requestMessage);

			//wait for response on the response queue
			var responseMessage = replyQueue.Receive();

			var body = responseMessage.GetBody<Stream>();
			var streamReader = new StreamReader(body);
			var response = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());

			responseMessage.Complete();
			_namespaceMgr.DeleteQueueAsync(replyTo);

			return response;
		}

		public void Send(BrokeredMessage requestMessage)
		{
			var topicClient = TopicClient.Create(Topic);
			//send the request message to queue
			topicClient.Send(requestMessage);
		}
	}
}