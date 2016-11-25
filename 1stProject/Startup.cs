using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1stProject.Startup))]
namespace _1stProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
