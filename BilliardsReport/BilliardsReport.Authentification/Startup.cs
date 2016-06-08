using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BilliardsReport.Authentification.Startup))]

namespace BilliardsReport.Authentification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
