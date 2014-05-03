using System.ServiceProcess;

namespace InformationExchange.ServiceBus.Host
{
    public class ServiceBusService : ServiceBase
    {
        private static ServiceBusManager _serviceBusManager;

        public ServiceBusService()
        {
            base.ServiceName = "Queue Bridge";
        }

        protected override void OnStart(string[] args)
        {
            _serviceBusManager = new ServiceBusManager();
            _serviceBusManager.Configure();
            _serviceBusManager.Start();
        }

        protected override void OnStop()
        {
            if (_serviceBusManager != null)
            {
                _serviceBusManager.Stop();
                _serviceBusManager = null;
            }
        }

        public void Start()
        {
            OnStart(null);
        }
    }
}