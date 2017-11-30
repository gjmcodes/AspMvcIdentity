using Domain.Entities.Auth;
using Domain.Interfaces.Repositories.Auth;

namespace CrossCutting.Data.Repositories.Auth
{
    public class UserRepository : BaseRepository<string, User>, IUserRepository
    {

        public void DeactivateLock(string id)
        {
            base._dbSet.Find(id).LockoutEnabled = false;
            base._db.SaveChanges();
        }
     
    }
}
