using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba_GIT_MVC.Startup))]
namespace Prueba_GIT_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
