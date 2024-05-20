using Microsoft.Extensions.DependencyInjection;
using MyWebForms.Core.Services;
using MyWebForms.Core.Web.Services.Abstractions;

namespace MyWebForms.Core.Web.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddScoped<IHttpContextService, HttpContextService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IResponseService, ResponseService>();
            services.AddScoped<ISessionService, SessionService>();

            return services;
        }
    }
}
