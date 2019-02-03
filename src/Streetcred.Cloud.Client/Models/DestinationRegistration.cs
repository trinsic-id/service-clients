// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Cloud.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a request to register a delivery association
    /// </summary>
    public partial class DestinationRegistration
    {
        /// <summary>
        /// Initializes a new instance of the DestinationRegistration class.
        /// </summary>
        public DestinationRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DestinationRegistration class.
        /// </summary>
        /// <param name="didOrKey">Gets the identifier.</param>
        public DestinationRegistration(string didOrKey = default(string))
        {
            DidOrKey = didOrKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "did_or_key")]
        public string DidOrKey { get; set; }

    }
}
