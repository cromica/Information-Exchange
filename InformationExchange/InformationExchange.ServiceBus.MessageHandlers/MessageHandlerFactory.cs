using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;

namespace InformationExchange.ServiceBus.MessageHandlers
{
    public class MessageHandlerFactory
    {
        private static MessageHandlerFactory _messageHandlerFactory;

        [ImportMany] public IEnumerable<Lazy<IMessageHandler>> MessageHandlers;

        public MessageHandlerFactory()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof (IMessageHandler).Assembly));

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            catalog.Catalogs.Add(new DirectoryCatalog(baseDirectory,"InformationExchange.*.dll"));
            catalog.Catalogs.Add(new DirectoryCatalog(baseDirectory, "InformationExchange.*.exe"));
            var container = new CompositionContainer(catalog, new ExportProvider[0]);
            container.ComposeParts(new object[] {this});
        }

        public static MessageHandlerFactory Instance
        {
            get
            {
                return _messageHandlerFactory ?? (_messageHandlerFactory = new MessageHandlerFactory());
            }
        }

        public static IMessageHandler GetHandler(string messageType)
        {
            return (from h in Instance.MessageHandlers
                    select h.Value).FirstOrDefault();
        }
    }
}