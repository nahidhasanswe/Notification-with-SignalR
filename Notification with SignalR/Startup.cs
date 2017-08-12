using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Notification_with_SignalR.Startup))]
namespace Notification_with_SignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
