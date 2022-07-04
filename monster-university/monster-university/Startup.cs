using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(monster_university.Startup))]
namespace monster_university
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
