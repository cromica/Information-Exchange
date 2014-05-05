using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using com.iex.orders.getorders;

namespace InformationExchange.ServiceBusTest
{
    class Program
    {
        static void Main(string[] args)
        {

           // var topic = "ordermanagement";
           // const string MessageType = "urn://com.iex.orders.GetOrders#OrderRequest";
           // var request = new OrderRequest();
           // request.Region = "Europe";
           // var connString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");
           //var namespaceMgr =  NamespaceManager.CreateFromConnectionString(connString);

            
           // var jsonSettings = new JsonSerializerSettings()
           // {
           //     Converters = new JsonConverter[] { new StringEnumConverter() },
           //     ContractResolver = new CustomContractResolver()
           // };
           // var req = JsonConvert.SerializeObject(request, jsonSettings);
           // var memoryStream = new MemoryStream();
           // var streamWriter = new StreamWriter(memoryStream);
           // streamWriter.Write(req);
           // streamWriter.Flush();
           // memoryStream.Flush();
           // memoryStream.Seek(0, SeekOrigin.Begin);

           // var bMessage = new BrokeredMessage(memoryStream,false);
           // bMessage.Properties.Add("region",request.Region);
           // bMessage.Label = MessageType;
           // bMessage.ContentType = "text/json";
           // bMessage.ReplyTo = "ordermanagementresponse";
           // bMessage.ReplyToSessionId = "1";

            
            
           // var topicClient = TopicClient.Create(topic);

           // topicClient.Send(bMessage);

        }
    }

    
}
