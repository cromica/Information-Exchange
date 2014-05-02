using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.BrokeredMessaging.Contracts;

namespace InformationExchange.BrokeredMessaging.MessageHandlers
{
    public interface IMessageHandler
    {
        object HandleMessage(BrokeredMessage message);
    }
}
