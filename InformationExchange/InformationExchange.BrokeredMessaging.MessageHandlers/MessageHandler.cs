using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.BrokeredMessaging.Contracts;
using InformationExchange.BrokeredMessaging.MessageHandlers.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InformationExchange.BrokeredMessaging.MessageHandlers
{
    public abstract class MessageHandler<TMessage>: IMessageHandler, IMessageHandlerMetadata where TMessage:class 
    {
        public abstract string HandledMessageType { get;  }

        public BrokeredMessage RequestEnvelope { get; private set; }

        public abstract object Handle(TMessage mesage);

        public object HandleMessage(BrokeredMessage message)
        {
            this.RequestEnvelope = message;
            return this.Handle(Unwrap(message));
        }

        protected TMessage Unwrap(BrokeredMessage message)
        {
            var tMessage = default(TMessage);
            var type = typeof (TMessage);
            var serializer = new JsonNetSerializer();
            var obj = serializer.Deserialize(message, type);

            tMessage = (obj as TMessage);

            return tMessage;
        }

       
    }
}
