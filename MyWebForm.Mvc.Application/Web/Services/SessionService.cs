using MyWebForms.Core.Services;
using MyWebForms.Core.Web.Services.Abstractions;
using System.Web;

namespace MyWebForms.Core.Web.Services
{
    internal class SessionService : ISessionService
    {

        private readonly HttpSessionStateBase _session;

        public SessionService(IHttpContextService service)
        {
            _session = service.HttpContext.Session;
        }

        public T Get<T>(SessionKey key)
        {
            return Get<T>(key.Name);
        }

        public T Get<T>(string keyName)
        {
            var value = _session?[keyName];
            if (value == null)
            {
                return default;
            }
            return (T)value;
        }

        public void Set<T>(SessionKey key, T value)
        {
            Set(key.Name, value);
        }

        public void Set<T>(string keyName, T value)
        {
            _session[keyName] = value;
        }

        public void Remove(SessionKey key)
        {
            Remove(key.Name);
        }

        public void Remove(string keyName)
        {
            _session.Remove(keyName);
        }
    }
}
