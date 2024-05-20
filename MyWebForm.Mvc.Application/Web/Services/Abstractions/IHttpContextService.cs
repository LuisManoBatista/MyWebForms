using System.Web;

namespace MyWebForms.Core.Web.Services.Abstractions
{
    public interface IHttpContextService
    {
        HttpContextBase HttpContext { get; }
    }

}
