// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Portal.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Configuration for creating tenant
    /// </summary>
    public partial class CreateTenant
    {
        /// <summary>
        /// Initializes a new instance of the CreateTenant class.
        /// </summary>
        public CreateTenant()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateTenant class.
        /// </summary>
        /// <param name="issuerSeed">(Optional) Issuer seed used for
        /// deterministic DID generation.
        /// If omitted, a random DID/Key is generated</param>
        /// <param name="name">The name of the tenant.</param>
        /// <param name="networkId">(Optional) Ledger network identifier.
        /// Default is Streetcred Test Network</param>
        public CreateTenant(string issuerSeed = default(string), string name = default(string), string networkId = default(string))
        {
            IssuerSeed = issuerSeed;
            Name = name;
            NetworkId = networkId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets (Optional) Issuer seed used for deterministic DID
        /// generation.
        /// If omitted, a random DID/Key is generated
        /// </summary>
        [JsonProperty(PropertyName = "issuer_seed")]
        public string IssuerSeed { get; set; }

        /// <summary>
        /// Gets or sets the name of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets (Optional) Ledger network identifier. Default is
        /// Streetcred Test Network
        /// </summary>
        [JsonProperty(PropertyName = "network_id")]
        public string NetworkId { get; set; }

    }
}
