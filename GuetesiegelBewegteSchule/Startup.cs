using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuetesiegelBewegteSchule.Startup))]
namespace GuetesiegelBewegteSchule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
