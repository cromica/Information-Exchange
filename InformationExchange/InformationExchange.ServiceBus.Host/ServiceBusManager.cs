using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using InformationExchange.ServiceBus.MessageHandlers;

namespace InformationExchange.ServiceBus.Host
{
    public class ServiceBusManager
    {
        private List<MessageProcessor> _messageProcessors;
		private List<Task> _tasks;
        public void Configure()
        {
          var connString = ConfigurationManager.ConnectionStrings["ServiceBusConnection"];
          var entityPathsStr = ConfigurationManager.AppSettings["EntityPaths"];
            _messageProcessors = new List<MessageProcessor>();
			_tasks = new List<Task>();
            //retrieve subscription pairs formed from entity path and forwarder
            var entityPaths = entityPathsStr.Split(',');
            foreach (var entityPath in entityPaths)
            {
                var splEntityPath = entityPath.Split('|');
                if(splEntityPath.Length != 2) throw new ArgumentException("Invalid EntityPaths");
                var path = splEntityPath[0];
                var forwarder = splEntityPath[1];
                var messageProcessor = new MessageProcessor(connString.ConnectionString, path, forwarder);
                _messageProcessors.Add(messageProcessor);
            }
            
        }

        public void Start()
        {
            if (_messageProcessors != null)
            {
                _messageProcessors.ForEach(messageProcessor =>
                    {
                        messageProcessor.Enabled = true;
						Console.WriteLine("Enabled {0} message processor", messageProcessor.Path);
						_tasks.Add(Task.Factory.StartNew(new Action(messageProcessor.Start)));
                    });
            }
        }

        public void Stop()
        {
            if (_messageProcessors != null)
            {
                _messageProcessors.ForEach(messageProcessor =>
                {
                    messageProcessor.Enabled = false;
                });

				_tasks = new List<Task>();
				_messageProcessors = new List<MessageProcessor>();
            }
          
        }
    }
}