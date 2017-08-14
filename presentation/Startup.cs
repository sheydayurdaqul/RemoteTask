using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(presentation.Startup))]
namespace presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
