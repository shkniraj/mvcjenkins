using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jenkins.Startup))]
namespace jenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
