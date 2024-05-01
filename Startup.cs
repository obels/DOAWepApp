using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOAWepApp.Startup))]
namespace DOAWepApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
