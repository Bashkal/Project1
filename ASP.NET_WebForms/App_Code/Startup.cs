using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_WebForms.Startup))]
namespace ASP.NET_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
