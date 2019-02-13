using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficialWebApp.Startup))]
namespace OfficialWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
