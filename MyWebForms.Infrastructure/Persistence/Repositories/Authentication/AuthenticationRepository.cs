using ErrorOr;
using MyWebForms.Core.Persistence.Abstractions;
using MyWebForms.Core.Persistence.Repositories.Base;
using System.Threading.Tasks;

namespace MyWebForms.Core.Persistence.Repositories.Authentication
{
    public sealed class AuthenticationRepository : RepositoryBase, IAuthenticationRepository
    {
        public AuthenticationRepository() : base(new DbContext())
        {
        }

        public AuthenticationRepository(IDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<ErrorOr<bool>> LoginAsync(string username, string password)
        {
            await Task.CompletedTask;
            return true;
        }
    }
}
