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

			new ServiceBusService().Start();
			Console.WriteLine("Listening on Azure Service Bus");
			Console.ReadLine();
		}
	}
}
