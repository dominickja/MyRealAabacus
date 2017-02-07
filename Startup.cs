using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAbacus.Startup))]
namespace MyAbacus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
