using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicMenuInMvc.Startup))]
namespace DynamicMenuInMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
