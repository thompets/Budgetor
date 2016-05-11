using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Budgetor.Web.Startup))]
namespace Budgetor.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
