using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.BrokeredMessaging.MessageHandlers;
using com.iex.orders.getorders;

namespace InformationExchange.Services.Europe.MessageHandlers
{
    [ExportMessageHandler(MessageType)]
    public class GetOrder_Handler : ReponseMessageHandler<OrderRequest,OrderResponse>
    {
        public const string MessageType = "urn://com.iex.orders.GetOrders#OrderRequest";

        public override string HandledMessageType
        {
            get { return MessageType; }
        }

        public override object Handle(OrderRequest mesage)
        {
            object oReturn = null;
            var service = new OrderInformationService();
            oReturn = service.GetOrders(mesage);
            return oReturn;
        }
    }
}
