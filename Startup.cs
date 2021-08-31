using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBtest4MVC.Startup))]
namespace DBtest4MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
