using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace InformationExchange.ServiceBus.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 & args[0] == "debug")
            {
                new ServiceBusService().Start();
            }
            else
            {
                ServiceBase.Run(new ServiceBase[] {new ServiceBusService()});
            }
        }
    }
}
