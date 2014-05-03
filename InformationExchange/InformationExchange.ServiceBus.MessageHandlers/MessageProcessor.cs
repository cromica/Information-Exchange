using System.IO;
using Microsoft.ServiceBus.Messaging;

namespace InformationExchange.ServiceBus.MessageHandlers
{
    public class MessageProcessor
    {
        private readonly string _connectionString;
        private readonly string _path;
        private readonly string _forwarder;

        private MessagingFactory _factory;

        public bool Enabled { get; set; }


        public MessageProcessor(string connectionString, string path, string forwarder)
        {
            _connectionString = connectionString;
            _path = path;
            _forwarder = forwarder;
        }

        
        public void Start()
        {
           while (Enabled)
           {
               _factory = MessagingFactory.CreateFromConnectionString(_connectionString);
               var messageReceiver = _factory.CreateMessageReceiver(_path, ReceiveMode.PeekLock);

               var brokeredMessage = messageReceiver.Receive();
               if (brokeredMessage == null) continue;

               var messageType = brokeredMessage.Label;
               var replyTo = brokeredMessage.ReplyTo;
               var replySessionId = brokeredMessage.ReplyToSessionId;

               var messageHandler = MessageHandlerFactory.GetHandler(string.Empty);
               messageHandler.Forwarder = _forwarder;

               var response = messageHandler.HandleRequestResponse(brokeredMessage);

               var responseMessageClient = new ResponseMessageClient(_connectionString, replyTo, replySessionId);

               responseMessageClient.SendResponse((MemoryStream) response, messageType);
              
               messageReceiver.Complete(brokeredMessage.LockToken);
           }
        }
    }
}