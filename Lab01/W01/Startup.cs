using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W01.Startup))]
namespace W01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
