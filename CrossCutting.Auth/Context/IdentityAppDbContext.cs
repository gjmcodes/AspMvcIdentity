using CrossCutting.Auth.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CrossCutting.Auth.Context
{
    public class IdentityAppDbContext : IdentityDbContext<IdentityAppUser>
    {
    }
}
