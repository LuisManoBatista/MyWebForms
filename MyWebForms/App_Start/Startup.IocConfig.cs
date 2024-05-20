using Microsoft.Extensions.DependencyInjection;
using MyWebForms.Core.Persistence;
using MyWebForms.Core.Web;
using MyWebForms.Core.Web.Factories;
using MyWebForms.Services;
using System;
using System.Web;
using System.Web.Mvc;
using ServiceCollection = Microsoft.Extensions.DependencyInjection.ServiceCollection;

namespace MyWebForms
{
    public partial class Startup
    {
        public static IServiceProvider ServiceProvider { get; private set; }


        public static void RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddScoped(sp => HttpContext.Current.GetOwinContext());

            services.AddControllersAsServices(typeof(Startup).Assembly);
            services.RegisterServices();
            services.AddPersistence();
            ServiceProvider = services.BuildServiceProvider();

            ServiceProvider.GetService<IIocControllerFactory>().SetCurrentControllerFactory();
            DependencyResolver.SetResolver(new ServiceProviderDependencyResolver(ServiceProvider));
        }
    }
}