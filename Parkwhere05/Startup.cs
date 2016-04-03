using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parkwhere05.Startup))]
namespace Parkwhere05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
