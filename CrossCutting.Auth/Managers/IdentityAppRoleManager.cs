using CrossCutting.Auth.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Auth.Managers
{
    public class IdentityAppRoleManager : RoleManager<IdentityRole>
    {
        public IdentityAppRoleManager(IRoleStore<IdentityRole, string> roleStore)
            :base(roleStore)
        {

        }

        public static IdentityAppRoleManager Create(IdentityFactoryOptions<IdentityAppRoleManager> options, IOwinContext context)
        {
            return new IdentityAppRoleManager(new RoleStore<IdentityRole>(context.Get<IdentityAppDbContext>()));
        }
    }
}
