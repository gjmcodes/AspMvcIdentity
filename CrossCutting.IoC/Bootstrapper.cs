using CrossCutting.Auth.Context;
using CrossCutting.Auth.Managers;
using CrossCutting.Auth.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IdentityAppDbContext>(Lifestyle.Scoped);
            container.Register<IUserStore<IdentityAppUser>>(() => new UserStore<IdentityAppUser>(new IdentityAppDbContext()), Lifestyle.Scoped);
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(), Lifestyle.Scoped);
            container.Register<IdentityAppRoleManager>(Lifestyle.Scoped);
            container.Register<IdentityAppUserManager>(Lifestyle.Scoped);
            container.Register<IdentityAppSignInManager>(Lifestyle.Scoped);

            //container.Register<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
