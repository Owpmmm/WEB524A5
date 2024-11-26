using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JK2247A5.Startup))]

namespace JK2247A5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
