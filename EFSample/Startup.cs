using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFSample.Startup))]
namespace EFSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
