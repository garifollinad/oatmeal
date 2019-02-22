using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oatmeal.Startup))]
namespace Oatmeal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
