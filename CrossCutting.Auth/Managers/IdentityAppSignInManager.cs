using CrossCutting.Auth.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CrossCutting.Auth.Managers
{
    public class IdentityAppSignInManager : SignInManager<IdentityAppUser, string>
    {
        public IdentityAppSignInManager(IdentityAppUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(IdentityAppUser user)
        {
            return user.GenerateUserIdentityAsync((IdentityAppUserManager)UserManager);
        }

        public static IdentityAppSignInManager Create(IdentityFactoryOptions<IdentityAppSignInManager> options, IOwinContext context)
        {
            return new IdentityAppSignInManager(context.GetUserManager<IdentityAppUserManager>(), context.Authentication);
        }
    }
}
