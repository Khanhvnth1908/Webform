using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W02.Startup))]
namespace W02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
