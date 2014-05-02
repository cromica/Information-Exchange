using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.BrokeredMessaging.Contracts
{
    [DataContract(Namespace = "http://com/iex/Messages")]
    public class BrokeredMessage 
    {
        [DataMember]
        public string BodyJson { get; set; }

        [DataMember]
        public string MessageType { get; set; }

    }
}
