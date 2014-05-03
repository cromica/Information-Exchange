using System.IO;
using Microsoft.ServiceBus.Messaging;

namespace InformationExchange.ServiceBus.MessageHandlers
{
    public class ResponseMessageClient
    {
        private readonly MessageSender _sender;
        private readonly string _replySessionId;
        public ResponseMessageClient(string connectionString, string replyTo, string replySessionId)
        {
            var factory = MessagingFactory.CreateFromConnectionString(connectionString);
            _sender = factory.CreateMessageSender(replyTo);
            _replySessionId = replySessionId;
        }

        public void SendResponse(MemoryStream message, string responseMessageType)
        {
            var brokeredMessage = new BrokeredMessage(message, false)
                {
                    ContentType = "text/json",
                    Label = responseMessageType,
                    ReplyToSessionId = _replySessionId,
                    SessionId = _replySessionId
                };
            SendResponse(brokeredMessage);
        }

        public void SendResponse(BrokeredMessage message)
        {
            try
            {
                _sender.Send(message);
            }
            finally
            {
                if (_sender != null)
                {
                    _sender.Close();
                }
            }
        }
    }
}