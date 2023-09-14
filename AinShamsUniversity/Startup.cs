using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AinShamsUniversity.Startup))]
namespace AinShamsUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
