using Microsoft.Data.SqlClient;

namespace MyWebForms.Core.Persistence.Abstractions
{
    public interface IDbContext
    {
        string ConnectionString { get; }

        SqlConnection CreateConnection();
    }
}
