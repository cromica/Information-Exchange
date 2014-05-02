using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.BrokeredMessaging.Contracts
{
    [ServiceContract(Namespace = "http://com/iex")]
    public interface IBrokeredMessageService
    {
        [WebGet(UriTemplate="submit?messageType={message}")]
        BrokeredMessage Submit(BrokeredMessage message);
    }
}
