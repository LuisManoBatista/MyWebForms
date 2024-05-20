using System.Web;

namespace MyWebForms.Core.Web.Services.Abstractions
{
    public interface IRequestService
    {
        HttpRequestBase Request { get; }
    }

}
