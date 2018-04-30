using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Training03.Startup))]
namespace Training03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
