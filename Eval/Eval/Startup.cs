using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eval.Startup))]
namespace Eval
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
