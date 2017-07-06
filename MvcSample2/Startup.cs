using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSample2.Startup))]
namespace MvcSample2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
