using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseworkApp.Startup))]
namespace CourseworkApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
