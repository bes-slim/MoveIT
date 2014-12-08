using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoveIT.Web.Startup))]
namespace MoveIT.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
