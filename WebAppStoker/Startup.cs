using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppStoker.Startup))]
namespace WebAppStoker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
