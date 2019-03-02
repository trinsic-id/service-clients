// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Portal.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProofRequestInfo
    {
        /// <summary>
        /// Initializes a new instance of the ProofRequestInfo class.
        /// </summary>
        public ProofRequestInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProofRequestInfo class.
        /// </summary>
        /// <param name="id">Gets or sets the identifier.</param>
        /// <param name="proofRequest">Gets or sets the proof request.</param>
        public ProofRequestInfo(string id = default(string), ProofRequest proofRequest = default(ProofRequest))
        {
            Id = id;
            ProofRequest = proofRequest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the proof request.
        /// </summary>
        [JsonProperty(PropertyName = "proofRequest")]
        public ProofRequest ProofRequest { get; set; }

    }
}