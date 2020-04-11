using Microsoft.Extensions.DependencyInjection;
using Wallace.Domain.Identity;
using Wallace.Domain.Identity.Entities;
using Wallace.Domain.Identity.Interfaces;

namespace Wallace.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(
            this IServiceCollection services
        )
        {
            services.AddSingleton<JwtConfiguration>();
            services.AddTransient<ITokenData, TokenData>();
            services.AddTransient<ITokenBuilder, TokenBuilder>();
            services.AddTransient<ITokenChecker, TokenChecker>();

            return services;
        }
    }
}