using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.BrokeredMessaging.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InformationExchange.BrokeredMessaging.MessageHandlers.Serialization
{
    public class JsonNetSerializer
    {
        private static JsonSerializerSettings Settings
        {
            get
            {
                var jsonSettings = new JsonSerializerSettings()
                    {
                        Converters = new JsonConverter[] {new StringEnumConverter()},
                        ContractResolver = new CustomContractResolver()
                    };
                return jsonSettings;
            }
        }

        public object Deserialize(BrokeredMessage message, Type type)
        {
           

            var obj = JsonConvert.DeserializeObject(message.BodyJson, type, Settings);
            return obj;
        }

        public object Serialize(Type type, object returnValue)
        {
            return JsonConvert.SerializeObject(returnValue, Settings);
        }
    }
}
