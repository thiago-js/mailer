using Mailer.Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Mailer.Domain.Extensions
{
    public static class DomainExtensions
    {
        public static IServiceCollection AddApplicationExtensions (this IServiceCollection services) {

            services.AddScoped<ISendMail, SendMail>();

            return services;
        }
    }
}