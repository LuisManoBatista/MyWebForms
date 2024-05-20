using ErrorOr;
using System.Threading.Tasks;

namespace MyWebForms.Core.Persistence.Abstractions
{
    public interface IAuthenticationRepository
    {
        Task<ErrorOr<bool>> LoginAsync(string username, string password);
    }
}
