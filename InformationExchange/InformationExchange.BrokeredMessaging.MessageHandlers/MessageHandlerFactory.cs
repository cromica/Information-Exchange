using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using InformationExchange.BrokeredMessaging.Contracts;

namespace InformationExchange.BrokeredMessaging.MessageHandlers
{
    public class MessageHandlerFactory
    {
        private static readonly MessageHandlerFactory _instance;

        [ImportMany]
        private IEnumerable<Lazy<IMessageHandler, IMessageHandlerMetadata>> Handlers { get; set; }

        static MessageHandlerFactory()
        {
            _instance = new MessageHandlerFactory();
            //Use MEF and catalogs to build a list of all message handlers
            var aggregateCatalog = new AggregateCatalog();
            aggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(IMessageHandler).Assembly));
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (OperationContext.Current != null)
            {
                string str = Path.Combine(baseDirectory, "bin");
                if (Directory.Exists(str))
                {
                    baseDirectory = str;
                }
            }
            var directoryCatalog = new DirectoryCatalog(baseDirectory,"InformationExchange.*.dll");
            aggregateCatalog.Catalogs.Add(directoryCatalog);

            var compositionContainer = new CompositionContainer(aggregateCatalog,new ExportProvider[0]);
            compositionContainer.ComposeParts(new object[] {_instance});

        }

        public static IMessageHandler GetHandler(string messageType)
        {
            IMessageHandler configuredMessagehandler = null;
            var handlers = from h in _instance.Handlers
                           where
                               h.Metadata.HandledMessageType == messageType
                           select h;
            if (handlers.Any())
            {
                configuredMessagehandler = handlers.First().Value;
            }

            return configuredMessagehandler;
        }
    }
}
