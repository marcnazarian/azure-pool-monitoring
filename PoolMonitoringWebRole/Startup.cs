using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoolMonitoringWebRole.Startup))]
namespace PoolMonitoringWebRole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
