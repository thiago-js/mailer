using Mailer.Domain.Contracts;
using Mailer.Infra.InMemory;
using Microsoft.Extensions.DependencyInjection;
using Mailer.Infra.Dapper;

namespace Mailer.Infra.Extensions
{
    public static class InfraExtensions
    {
        public static IServiceCollection AddInMemoryExtensions(this IServiceCollection services) 
        {
            services.AddScoped<ITemplateRepository, TemplateInMemoryRepository>();

            return services;
        }

        public static IServiceCollection AddDapperExtensions(this IServiceCollection services, string _connection) 
        {
            services.AddSingleton(new ConnectionString(_connection));

            return services;
        }
    }
}