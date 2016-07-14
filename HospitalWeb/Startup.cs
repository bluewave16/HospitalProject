using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalWeb.Startup))]
namespace HospitalWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
