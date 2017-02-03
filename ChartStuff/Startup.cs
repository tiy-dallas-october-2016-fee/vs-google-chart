using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChartStuff.Startup))]
namespace ChartStuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
