using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformationExchange.Order.Web.Startup))]
namespace InformationExchange.Order.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
