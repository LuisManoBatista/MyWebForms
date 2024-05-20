using MyWebForms.Core.Web.Services.Abstractions;
using System.Web;

namespace MyWebForms.Core.Web.Services
{
    internal class RequestService : IRequestService
    {
        private readonly IHttpContextService _service;
        public RequestService(IHttpContextService service)
        {
            _service = service;
        }
        public HttpRequestBase Request => _service.HttpContext.Request;
    }

}
