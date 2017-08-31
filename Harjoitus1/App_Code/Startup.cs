using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Harjoitus1.Startup))]
namespace Harjoitus1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
