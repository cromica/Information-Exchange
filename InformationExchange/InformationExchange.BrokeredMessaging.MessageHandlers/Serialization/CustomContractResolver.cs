using System;
using Newtonsoft.Json.Serialization;

namespace InformationExchange.BrokeredMessaging.MessageHandlers.Serialization
{
    public class CustomContractResolver : DefaultContractResolver
    {
        protected override JsonContract CreateContract(Type objectType)
        {
            JsonContract jsonContract = base.CreateContract(objectType);
            if (!(jsonContract is JsonStringContract))
            {
                return jsonContract;
            }
            return this.CreateObjectContract(objectType);
        }
    }
}