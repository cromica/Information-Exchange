using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.BrokeredMessaging.Contracts
{
    [DataContract(Namespace = "http://com/iex/Messages")]
    [TypeConverter(typeof(BrokeredMessageTypeConverter))]
    public class BrokeredMessage 
    {
        [DataMember]
        public string BodyJson { get; set; }

        [DataMember]
        public string MessageType { get; set; }

    }

    public class BrokeredMessageTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof (string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture,
                                           object value)
        {
            string str = value as string;
            if (str != null)
            {
                return BrokeredMessageTypeConverter.GetBrokeredMessageFromString(str);
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return true;
            // throw new NotImplementedException("Not supporterd");
        }

        private static object GetBrokeredMessageFromString(string str)
        {
            throw new NotImplementedException();
        }
    }
}
