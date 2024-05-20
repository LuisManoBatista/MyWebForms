using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyWebForms.Core.Persistence.Abstractions;
using MyWebForms.Core.Persistence.Repositories;
using MyWebForms.Core.Persistence.Repositories.Authentication;
using MyWebForms.Web.Infrastructure;

namespace MyWebForms.Core.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddSingleton<IOptions<DefaultConnectionStringConfiguration>>(
                new OptionsWrapper<DefaultConnectionStringConfiguration>(
                    new DefaultConnectionStringConfiguration
                    {
                        ConnectionString = ConfigurationManagerWrapper.GetConnectionString()
                    }));

            services.AddSingleton<IDbContext>(sp => new DbContext(sp.GetService<IOptions<DefaultConnectionStringConfiguration>>()));
            services.AddTransient<IAuthenticationRepository>(sp => new AuthenticationRepository(sp.GetService<IDbContext>()));
            return services;
        }


    }
}
