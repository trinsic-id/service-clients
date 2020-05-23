using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Rest;
// ReSharper disable CheckNamespace

namespace Microsoft.Extensions.DependencyInjection
{
    public class StreetcredManagementCredentials : ServiceClientCredentials
    {
        /// <summary>
        /// Gets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public ServiceClientOptions Options { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreetcredClientCredentials"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public StreetcredManagementCredentials(IOptions<ServiceClientOptions> options)
        {
            Options = options.Value;
        }

        /// <inheritdoc />
        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", $"Bearer {Options.AccountSecret}");
            request.Headers.Add("X-Streetcred-Subscription-Key", Options.SubscriptionKey);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}