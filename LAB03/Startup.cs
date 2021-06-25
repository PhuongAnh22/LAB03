using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB03.Startup))]
namespace LAB03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
