using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebThreeTierOfcMgtSystem.Startup))]
namespace WebThreeTierOfcMgtSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
