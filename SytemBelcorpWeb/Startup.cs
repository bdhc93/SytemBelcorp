using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SytemBelcorpWeb.Startup))]
namespace SytemBelcorpWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
