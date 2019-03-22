using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hand_Made_Dress.Web.Startup))]
namespace Hand_Made_Dress.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
