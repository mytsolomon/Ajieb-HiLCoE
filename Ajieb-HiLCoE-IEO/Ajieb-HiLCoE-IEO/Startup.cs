using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ajieb_HiLCoE_IEO.Startup))]
namespace Ajieb_HiLCoE_IEO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
