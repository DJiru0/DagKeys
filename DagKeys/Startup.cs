using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DagKeys.Startup))]
namespace DagKeys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
