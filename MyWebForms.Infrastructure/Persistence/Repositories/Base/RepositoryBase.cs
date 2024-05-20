using MyWebForms.Core.Persistence.Abstractions;

namespace MyWebForms.Core.Persistence.Repositories.Base
{
    public class RepositoryBase
    {
        protected RepositoryBase(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private readonly IDbContext _dbContext;

        protected IDbContext Context => _dbContext;
    }
}
