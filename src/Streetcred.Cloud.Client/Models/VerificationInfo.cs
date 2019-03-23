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
    /// Verification Info
    /// </summary>
    public partial class VerificationInfo
    {
        /// <summary>
        /// Initializes a new instance of the VerificationInfo class.
        /// </summary>
        public VerificationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VerificationInfo class.
        /// </summary>
        /// <param name="connectionId">Gets or sets the connection
        /// identifier.</param>
        /// <param name="verificationId">Gets or sets the verification
        /// identifier.</param>
        /// <param name="state">Gets or sets the state. Possible values
        /// include: 'Requested', 'Accepted', 'Rejected'</param>
        /// <param name="createdAtUtc">Gets or sets the created at UTC.</param>
        /// <param name="updatedAtUtc">Gets or sets the updated at UTC.</param>
        /// <param name="isValid">Returns true if the provided proof is
        /// valid.</param>
        /// <param name="verifiedAtUtc">Gets or sets the verified at
        /// UTC.</param>
        public VerificationInfo(string connectionId = default(string), string verificationId = default(string), string state = default(string), System.DateTime? createdAtUtc = default(System.DateTime?), System.DateTime? updatedAtUtc = default(System.DateTime?), bool? isValid = default(bool?), System.DateTime? verifiedAtUtc = default(System.DateTime?))
        {
            ConnectionId = connectionId;
            VerificationId = verificationId;
            State = state;
            CreatedAtUtc = createdAtUtc;
            UpdatedAtUtc = updatedAtUtc;
            IsValid = isValid;
            VerifiedAtUtc = verifiedAtUtc;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection identifier.
        /// </summary>
        [JsonProperty(PropertyName = "connectionId")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the verification identifier.
        /// </summary>
        [JsonProperty(PropertyName = "verificationId")]
        public string VerificationId { get; set; }

        /// <summary>
        /// Gets or sets the state. Possible values include: 'Requested',
        /// 'Accepted', 'Rejected'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the created at UTC.
        /// </summary>
        [JsonProperty(PropertyName = "createdAtUtc")]
        public System.DateTime? CreatedAtUtc { get; set; }

        /// <summary>
        /// Gets or sets the updated at UTC.
        /// </summary>
        [JsonProperty(PropertyName = "updatedAtUtc")]
        public System.DateTime? UpdatedAtUtc { get; set; }

        /// <summary>
        /// Gets or sets returns true if the provided proof is valid.
        /// </summary>
        [JsonProperty(PropertyName = "isValid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets or sets the verified at UTC.
        /// </summary>
        [JsonProperty(PropertyName = "verifiedAtUtc")]
        public System.DateTime? VerifiedAtUtc { get; set; }

    }
}
