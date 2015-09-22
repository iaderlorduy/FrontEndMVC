using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontEndAPI.Startup))]
namespace FrontEndAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
