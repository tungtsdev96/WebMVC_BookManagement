using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fa.WebMVC.Presentation.Startup))]
namespace Fa.WebMVC.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
