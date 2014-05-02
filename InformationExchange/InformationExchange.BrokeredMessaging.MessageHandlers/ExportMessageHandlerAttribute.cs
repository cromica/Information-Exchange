using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.BrokeredMessaging.MessageHandlers
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
    [MetadataAttribute]
    public class ExportMessageHandlerAttribute : ExportAttribute
    {
        public string HandledMessageType { get; set; }

        public ExportMessageHandlerAttribute(): base(typeof(IMessageHandler))
        {
            
        }

        public ExportMessageHandlerAttribute(string handledMessageType):base(typeof(IMessageHandler))
        {
            this.HandledMessageType = handledMessageType;
        }
    }
}
