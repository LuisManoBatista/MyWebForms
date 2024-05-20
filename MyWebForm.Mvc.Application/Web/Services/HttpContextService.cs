using MyWebForms.Core.Web.Services.Abstractions;
using System.Web;

namespace MyWebForms.Core.Web.Services
{
    internal class HttpContextService : IHttpContextService
    {
        public HttpContextBase HttpContext => new HttpContextWrapper(System.Web.HttpContext.Current);
    }

}
