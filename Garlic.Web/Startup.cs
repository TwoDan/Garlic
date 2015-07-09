using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Garlic.Web.Startup))]
namespace Garlic.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
