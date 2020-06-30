using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Rest;
// ReSharper disable CheckNamespace

namespace Microsoft.Extensions.DependencyInjection
{
    public class TrinsicProviderCredentials : ServiceClientCredentials
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
        public TrinsicProviderCredentials(IOptions<ServiceClientOptions> options)
        {
            Options = options.Value;
        }

        /// <inheritdoc />
        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", $"Bearer {Options.ProviderKey}");
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}