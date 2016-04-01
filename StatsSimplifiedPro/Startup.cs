using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatsSimplifiedPro.Startup))]
namespace StatsSimplifiedPro
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
