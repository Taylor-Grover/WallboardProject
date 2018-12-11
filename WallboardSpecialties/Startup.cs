using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WallboardSpecialties.Startup))]
namespace WallboardSpecialties
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
