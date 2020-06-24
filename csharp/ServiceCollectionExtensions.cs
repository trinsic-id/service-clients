using System;
using Microsoft.Extensions.Options;
using Trinsic.ServiceClients;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the required services for access to Trinsic's API's including Credentials and Wallet services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configure">The configure.</param>
        /// <returns></returns>
        public static IServiceCollection AddTrinsicClient(this IServiceCollection services, Action<ServiceClientOptions> configure)
        {
            services.Configure(configure);
            services.AddSingleton<TrinsicClientCredentials>();
            services.AddSingleton<TrinsicProviderCredentials>();
            services.AddSingleton<ICredentialsServiceClient, CredentialsServiceClient>(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ServiceClientOptions>>().Value;
                var credentialsClient = new CredentialsServiceClient(provider.GetRequiredService<TrinsicClientCredentials>());
                credentialsClient.BaseUri = options.CredentialsBaseUri == null ? credentialsClient.BaseUri : new Uri(options.CredentialsBaseUri);
                return credentialsClient;
            });
            services.AddSingleton<IWalletServiceClient, WalletServiceClient>(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ServiceClientOptions>>().Value;
                var walletClient = new WalletServiceClient(provider.GetRequiredService<TrinsicClientCredentials>());
                walletClient.BaseUri = options.WalletBaseUri == null ? walletClient.BaseUri : new Uri(options.WalletBaseUri);
                return walletClient;
            });
            services.AddSingleton<IProviderServiceClient, ProviderServiceClient>(provider =>
            {
                var options = provider.GetRequiredService<IOptions<ServiceClientOptions>>().Value;
                var providerClient = new ProviderServiceClient(provider.GetRequiredService<TrinsicProviderCredentials>());
                providerClient.BaseUri = options.ProviderBaseUri == null ? providerClient.BaseUri : new Uri(options.ProviderBaseUri);
                return providerClient;
            });
            return services;
        }
    }
}