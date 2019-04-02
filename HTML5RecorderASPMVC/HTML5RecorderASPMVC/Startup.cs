using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTML5RecorderASPMVC.Startup))]
namespace HTML5RecorderASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
