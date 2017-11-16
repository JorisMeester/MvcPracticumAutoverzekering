using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPracticumAutoverzekering.Startup))]
namespace MvcPracticumAutoverzekering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
