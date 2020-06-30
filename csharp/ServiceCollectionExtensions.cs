using System;
using Microsoft.Extensions.Options;
using Streetcred.ServiceClients;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the required services for access to Streetcred's API's including Agency and Custodian services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configure">The configure.</param>
        /// <returns></returns>
        public static IServiceCollection AddStreetcredClient(this IServiceCollection services, Action<ServiceClientOptions> configure)
        {
            services.Configure(configure);
            services.AddSingleton<StreetcredClientCredentials>();
            services.AddSingleton<StreetcredManagementCredentials>();
            services.AddSingleton<IAgencyServiceClient, AgencyServiceClient>(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ServiceClientOptions>>().Value;
                var agencyClient = new AgencyServiceClient(provider.GetRequiredService<StreetcredClientCredentials>());
                agencyClient.BaseUri = options.AgencyBaseUri == null ? agencyClient.BaseUri : new Uri(options.AgencyBaseUri);
                return agencyClient;
            });
            services.AddSingleton<ICustodianServiceClient, CustodianServiceClient>(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ServiceClientOptions>>().Value;
                var custodianClient = new CustodianServiceClient(provider.GetRequiredService<StreetcredClientCredentials>());
                custodianClient.BaseUri = options.CustodianBaseUri == null ? custodianClient.BaseUri : new Uri(options.CustodianBaseUri);
                return custodianClient;
            });
            services.AddSingleton<IManagementServiceClient, ManagementServiceClient>(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ServiceClientOptions>>().Value;
                var managementClient = new ManagementServiceClient(provider.GetRequiredService<StreetcredManagementCredentials>());
                managementClient.BaseUri = options.ManagementBaseUri == null ? managementClient.BaseUri : new Uri(options.ManagementBaseUri);
                return managementClient;
            });
            return services;
        }
    }
}