using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CorseProject1517.Startup))]
namespace CorseProject1517
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
