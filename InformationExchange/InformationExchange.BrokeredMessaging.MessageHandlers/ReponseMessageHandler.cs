using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.BrokeredMessaging.MessageHandlers
{
    public abstract class ReponseMessageHandler<TRequestMessage, TResponseMessage>: MessageHandler<TRequestMessage>, IResponseMessageHandler
        where TRequestMessage:class 
    {
        public string ResponseMessageType
        {
            get { return GetMessageTypeName(typeof (TResponseMessage)); }
        }

        private string GetMessageTypeName(Type type)
        {
            if (type.GetCustomAttributes(typeof(DataContractAttribute), false).Length == 1)
            {
                throw new ApplicationException("The data contract attribute is not specified");
            }
            var customAttributes = type.GetCustomAttributes(typeof(DataContractAttribute), false)[0] as DataContractAttribute;
            string str = (customAttributes != null && string.IsNullOrEmpty(customAttributes.Name) ? type.Name : customAttributes.Name);
            return string.Format("{0}#{1}", customAttributes.Namespace, str);
        }

    }
}
