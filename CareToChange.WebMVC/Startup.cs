using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareToChange.WebMVC.Startup))]
namespace CareToChange.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
