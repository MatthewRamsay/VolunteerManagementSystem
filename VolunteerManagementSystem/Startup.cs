using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VolunteerManagementSystem.Startup))]
namespace VolunteerManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
