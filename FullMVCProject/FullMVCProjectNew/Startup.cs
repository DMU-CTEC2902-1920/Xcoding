using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullMVCProjectNew.Startup))]
namespace FullMVCProjectNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
