using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week6Lab2.Startup))]
namespace Week6Lab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
