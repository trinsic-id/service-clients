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
        /// Gets or sets the agency base URI.
        /// <remarks>
        /// Use this field to override the default base URI, otherwise leave <c>null</c>.
        /// </remarks>
        /// </summary>
        /// <value>
        /// The agency base URI.
        /// </value>
        public string AgencyBaseUri { get; set; }

        /// <summary>
        /// Gets or sets the custodian base URI.
        /// </summary>
        /// <remarks>
        /// Use this field to override the default base URI, otherwise leave <c>null</c>.
        /// </remarks>
        /// <value>
        /// The custodian base URI.
        /// </value>
        public string CustodianBaseUri { get; set; }

        /// <summary>
        /// Gets or sets the management base URI.
        /// </summary>
        /// <remarks>
        /// Use this field to override the default base URI, otherwise leave <c>null</c>.
        /// </remarks>
        /// <value>
        /// The custodian base URI.
        /// </value>
        public string ManagementBaseUri { get; set; }
    }
}