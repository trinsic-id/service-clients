namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Service Client Options
    /// </summary>
    public class ServiceClientOptions
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>
        /// The access token.
        /// </value>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the account secret
        /// </summary>
        /// <value>
        /// The access token.
        /// </value>
        public string AccountSecret { get; set; }

        /// <summary>
        /// Gets or sets the subscription key.
        /// </summary>
        /// <value>
        /// The subscription key.
        /// </value>
        public string SubscriptionKey { get; set; }

        /// <summary>
        /// Gets or sets the credentials base URI.
        /// <remarks>
        /// Use this field to override the default base URI, otherwise leave <c>null</c>.
        /// </remarks>
        /// </summary>
        /// <value>
        /// The credentials base URI.
        /// </value>
        public string CredentialsBaseUri { get; set; }

        /// <summary>
        /// Gets or sets the wallet base URI.
        /// </summary>
        /// <remarks>
        /// Use this field to override the default base URI, otherwise leave <c>null</c>.
        /// </remarks>
        /// <value>
        /// The wallet base URI.
        /// </value>
        public string WalletBaseUri { get; set; }

        /// <summary>
        /// Gets or sets the provider base URI.
        /// </summary>
        /// <remarks>
        /// Use this field to override the default base URI, otherwise leave <c>null</c>.
        /// </remarks>
        /// <value>
        /// The provider base URI.
        /// </value>
        public string ProviderBaseUri { get; set; }
    }
}