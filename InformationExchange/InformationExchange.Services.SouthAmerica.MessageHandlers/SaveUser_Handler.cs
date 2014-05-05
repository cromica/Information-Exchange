using com.iex.orders.saveuser;
using InformationExchange.BrokeredMessaging.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.Services.SouthAmerica.MessageHandlers
{
	[ExportMessageHandler(MessageType)]
	public class SaveUser_Handler : MessageHandler<UserRequest>
	{
		public const string MessageType = "urn://com.iex.orders.SaveUser#UserRequest";

		public override string HandledMessageType
		{
			get { return MessageType; }
		}

		public override object Handle(UserRequest mesage)
		{
			var service = new OrderInformationService();
			return service.SaveUser(mesage);

		}
	}
}
