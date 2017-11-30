using Microsoft.Owin;
using Owin;
using ProjetoIdentityAuth;

[assembly: OwinStartup(typeof(Startup))]
namespace ProjetoIdentityAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}