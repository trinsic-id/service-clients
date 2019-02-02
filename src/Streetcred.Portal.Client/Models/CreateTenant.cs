// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Portal.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Configuration options for creating new tenant
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
        /// <param name="name">The name of the tenant.</param>
        /// <param name="issuerSeed">(Optional) Issuer seed used for
        /// deterministic DID generation.
        /// If omitted, a random DID/Key is generated</param>
        /// <param name="imageUrl">(Optional) Location of image URL used as
        /// profile for this tenant</param>
        /// <param name="networkId">(Optional) Ledger network identifier.
        /// Default is Streetcred Test Network</param>
        public CreateTenant(string name, string issuerSeed = default(string), string imageUrl = default(string), string networkId = default(string))
        {
            IssuerSeed = issuerSeed;
            Name = name;
            ImageUrl = imageUrl;
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
        /// Gets or sets (Optional) Location of image URL used as profile for
        /// this tenant
        /// </summary>
        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets (Optional) Ledger network identifier. Default is
        /// Streetcred Test Network
        /// </summary>
        [JsonProperty(PropertyName = "network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
