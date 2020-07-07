using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetDeveloper.Startup))]
namespace NetDeveloper
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
