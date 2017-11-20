using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookShop_CA.Startup))]
namespace BookShop_CA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
