using MyWebForms.Core.Web.Services.Abstractions;
using System.Web;

namespace MyWebForms.Core.Web.Services
{
    internal class ResponseService : IResponseService
    {
        private readonly IHttpContextService _service;

        public ResponseService(IHttpContextService service)
        {
            _service = service;

        }
        public HttpResponseBase Response => _service.HttpContext.Response;
    }

}
