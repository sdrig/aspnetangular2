using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnetangular2.Startup))]
namespace aspnetangular2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
