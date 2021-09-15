using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG.Startup))]
namespace PRG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
