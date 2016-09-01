using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCrud.Startup))]
namespace TestCrud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
