using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicMenuMVC.Startup))]
namespace DynamicMenuMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
