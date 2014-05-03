using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.BrokeredMessaging.Contracts;
using InformationExchange.BrokeredMessaging.MessageHandlers;
using InformationExchange.BrokeredMessaging.MessageHandlers.Serialization;

namespace InformationExchange.BrokeredMessaging.Services
{
    public class BrokeredMessageService : IBrokeredMessageService
    {
        public BrokeredMessage Submit(BrokeredMessage message)
        {
            BrokeredMessage brokeredMessage;
            if (string.IsNullOrEmpty(message.MessageType))
            {
                throw new FaultException("MessageType is not specified");
            }
            if (string.IsNullOrEmpty(message.BodyJson))
            {
                throw new FaultException("BodyJson is not specified");
            }

            //get the appropriate message handler for the message
            var handler = MessageHandlerFactory.GetHandler(message.MessageType);

            var returnMessage = handler.HandleMessage(message);

            if (!(returnMessage is BrokeredMessage))
            {
                brokeredMessage = new BrokeredMessage();
                brokeredMessage.MessageType = message.MessageType;
                var serializer = new JsonNetSerializer();
                var str = serializer.Serialize(returnMessage.GetType(), returnMessage) as string;
                brokeredMessage.BodyJson = str;
            }
            else
            {
                brokeredMessage = (BrokeredMessage) returnMessage;
            }

            return brokeredMessage;
        }
    }
}
