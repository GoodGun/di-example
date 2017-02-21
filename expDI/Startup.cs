using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(expDI.Startup))]
namespace expDI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
