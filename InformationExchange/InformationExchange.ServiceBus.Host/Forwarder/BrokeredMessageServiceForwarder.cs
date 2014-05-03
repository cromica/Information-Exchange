using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.ServiceBus.MessageHandlers;
using com.iex.Messages;

namespace InformationExchange.ServiceBus.Host.Forwarder
{
    [Export(typeof(IMessageHandler))]
    public class BrokeredMessageServiceForwarder : IMessageHandler
    {
        public string Forwarder { get; set; }

        public object HandleRequestResponse(Microsoft.ServiceBus.Messaging.BrokeredMessage message)
        {
            if (message == null) throw new ApplicationException("Message is null");

            var outputMessage = SendToBrokeredMessageService(message);

            

           return GetResponseBodyAsStream(outputMessage);
        }

        private Stream GetResponseBodyAsStream(BrokeredMessage responseMessage)
        {
            var stream = new MemoryStream();

            var writer = new StreamWriter(stream);
            writer.Write(responseMessage.BodyJson);
            writer.Flush();
            stream.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }

        private BrokeredMessage SendToBrokeredMessageService(Microsoft.ServiceBus.Messaging.BrokeredMessage azureMessage)
        {
            var inputMessage = ConvertToMessage(azureMessage);
            var client = new BrokeredMessageServiceClient(Forwarder);
            return client.Submit(inputMessage);
        }

        private BrokeredMessage ConvertToMessage(Microsoft.ServiceBus.Messaging.BrokeredMessage azureMessage)
        {
            var message = new BrokeredMessage {MessageType = azureMessage.Label};
            var body = azureMessage.GetBody<Stream>();
            var streamReader = new StreamReader(body);
            message.BodyJson = streamReader.ReadToEnd();

            return message;
        }
    }
}
