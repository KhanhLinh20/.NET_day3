using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(day3.Startup))]
namespace day3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
