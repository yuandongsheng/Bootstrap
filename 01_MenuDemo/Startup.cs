using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01_MenuDemo.Startup))]
namespace _01_MenuDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
