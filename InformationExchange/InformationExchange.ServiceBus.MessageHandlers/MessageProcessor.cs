using System.IO;
using Microsoft.ServiceBus.Messaging;
using System;

namespace InformationExchange.ServiceBus.MessageHandlers
{
	public class MessageProcessor
	{
		private readonly string _connectionString;
		private readonly string _path;
		private readonly string _forwarder;

		private MessagingFactory _factory;

		public bool Enabled { get; set; }
		public string Path { get { return _path; } }

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

			   Console.WriteLine("Received message {0} on {1} and forwarded to {2}", messageType, _path, _forwarder);

			   var response = messageHandler.HandleRequestResponse(brokeredMessage);

			   if (!string.IsNullOrEmpty(replyTo))
			   {
				   var responseMessageClient = new ResponseMessageClient(_connectionString, replyTo, replySessionId);
				   Console.WriteLine("Send message response");
				   responseMessageClient.SendResponse((MemoryStream)response, messageType);
			   }

			   messageReceiver.Complete(brokeredMessage.LockToken);
		   }
		}
	}
}