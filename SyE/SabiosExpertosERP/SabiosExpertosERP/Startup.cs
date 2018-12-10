using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SabiosExpertosERP.Startup))]
namespace SabiosExpertosERP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
