using System.Web;

namespace MyWebForms.Core.Web.Services.Abstractions
{
    public interface IResponseService
    {
        HttpResponseBase Response { get; }
    }

}
