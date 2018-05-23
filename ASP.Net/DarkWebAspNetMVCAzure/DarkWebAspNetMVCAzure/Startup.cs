using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DarkWebAspNetMVCAzure.Startup))]
namespace DarkWebAspNetMVCAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
