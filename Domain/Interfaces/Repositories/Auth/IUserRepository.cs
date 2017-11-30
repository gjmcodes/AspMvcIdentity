using Domain.Entities.Auth;

namespace Domain.Interfaces.Repositories.Auth
{
    public interface  IUserRepository : IBaseRepository<string, User>
    {
        void DeactivateLock(string id);
    }
}
