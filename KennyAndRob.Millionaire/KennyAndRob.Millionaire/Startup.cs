using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KennyAndRob.Millionaire.Startup))]
namespace KennyAndRob.Millionaire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
