using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinginOAuth.Startup))]
namespace SinginOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
