using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MyWebForms.Core.Persistence.Abstractions;
using MyWebForms.Web.Infrastructure;

namespace MyWebForms.Core.Persistence.Repositories
{
    public class DbContext : IDbContext
    {
        private readonly string _connectionString;

        public DbContext(IOptions<DefaultConnectionStringConfiguration> options)
        {
            _connectionString = options.Value.ConnectionString;
        }

        public DbContext()
        {
            _connectionString = ConfigurationManagerWrapper.GetConnectionString();
        }

        public string ConnectionString => _connectionString;

        public SqlConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
