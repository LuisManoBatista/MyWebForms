using Microsoft.Extensions.DependencyInjection;
using MyWebForms.Core.Web.Factories;
using System.Reflection;
using System.Web.Mvc;

namespace MyWebForms.Core.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddControllersAsServices(this IServiceCollection services, Assembly entryAssembly)
        {
            services.AddSingleton<IIocControllerFactory>(s => new IocControllerFactory(s));

            foreach (var type in entryAssembly.GetExportedTypes())
            {
                if (type.IsClass && !type.IsAbstract && typeof(IController).IsAssignableFrom(type))
                {
                    services.AddTransient(type);
                }
            }

            return services;
        }
    }
}
