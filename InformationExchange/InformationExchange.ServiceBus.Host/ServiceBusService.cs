using System.ServiceProcess;

namespace InformationExchange.ServiceBus.Host
{
	public class ServiceBusService 
	{
		private static ServiceBusManager _serviceBusManager;

		public ServiceBusService()
		{
		}

		public void Start()
		{
			_serviceBusManager = new ServiceBusManager();
			_serviceBusManager.Configure();
			_serviceBusManager.Start();
		}
	}
}