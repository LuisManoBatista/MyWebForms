using MyWebForms.Core.Web;

namespace MyWebForms.Core.Services
{
    public interface ISessionService
    {
        T Get<T>(SessionKey key);

        T Get<T>(string keyName);

        void Set<T>(SessionKey key, T value);

        void Set<T>(string keyName, T value);

        void Remove(SessionKey key);

        void Remove(string keyName);
    }
}
