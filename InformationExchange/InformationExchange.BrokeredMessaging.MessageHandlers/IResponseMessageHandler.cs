using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.BrokeredMessaging.MessageHandlers
{
    public interface IResponseMessageHandler : IMessageHandler
    {
        string ResponseMessageType { get; }
    }
}
