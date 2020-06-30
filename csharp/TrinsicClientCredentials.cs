using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Rest;
// ReSharper disable CheckNamespace

namespace Microsoft.Extensions.DependencyInjection
{
    public class TrinsicClientCredentials : ServiceClientCredentials
    {
        /// <summary>
        /// Gets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public ServiceClientOptions Options { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrinsicClientCredentials"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public TrinsicClientCredentials(IOptions<ServiceClientOptions> options)
        {
            Options = options.Value;
        }

        /// <inheritdoc />
        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", $"Bearer {Options.AccessToken}");
            request.Headers.Add("X-Trinsic-Subscription-Key", Options.SubscriptionKey);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}