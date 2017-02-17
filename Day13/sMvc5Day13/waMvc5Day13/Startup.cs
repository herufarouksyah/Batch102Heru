using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(waMvc5Day13.Startup))]
namespace waMvc5Day13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
