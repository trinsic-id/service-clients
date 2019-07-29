using System;
using Microsoft.Rest;
using Streetcred.ServiceClients;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddStreetcredClient(this IServiceCollection services, Action<ServiceClientOptions> configure)
        {
            services.Configure(configure);
            services.AddSingleton<StreetcredClientCredentials>();
            services.AddSingleton<IAgencyServiceClient, AgencyServiceClient>(provider =>
                new AgencyServiceClient(provider.GetRequiredService<StreetcredClientCredentials>()));
            return services;
        }

        public static IServiceCollection AddStreetcredClient(this IServiceCollection services)
        {
            return AddStreetcredClient(services, options => { });
        }
    }
}