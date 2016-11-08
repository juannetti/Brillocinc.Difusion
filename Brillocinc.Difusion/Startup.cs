using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brillocinc.Difusion.Startup))]
namespace Brillocinc.Difusion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
