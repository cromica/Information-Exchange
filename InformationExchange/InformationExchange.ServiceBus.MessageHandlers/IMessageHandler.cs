using Microsoft.ServiceBus.Messaging;

namespace InformationExchange.ServiceBus.MessageHandlers
{
    public interface IMessageHandler
    {
        string Forwarder { get; set; }
        object HandleRequestResponse(BrokeredMessage message);
    }
}