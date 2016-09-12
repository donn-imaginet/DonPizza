using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATBPizza.Startup))]
namespace ATBPizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
