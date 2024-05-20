using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MyWebForms.Services.Abstractions;

namespace MyWebForms.Services
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.TryAddScoped<IDemoService, DemoService>();
            return services;
        }
    }
}