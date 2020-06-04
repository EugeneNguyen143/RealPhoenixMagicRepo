using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiantSchool.Startup))]
namespace GiantSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
