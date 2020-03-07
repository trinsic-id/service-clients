using System;
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
            services.AddSingleton<ICustodianServiceClient, CustodianServiceClient>(provider =>
                new CustodianServiceClient(provider.GetRequiredService<StreetcredClientCredentials>()));
            return services;
        }
    }
}