using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blockbusta.Startup))]
namespace Blockbusta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
