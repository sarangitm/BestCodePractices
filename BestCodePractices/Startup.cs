using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestCodePractices.Startup))]
namespace BestCodePractices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
