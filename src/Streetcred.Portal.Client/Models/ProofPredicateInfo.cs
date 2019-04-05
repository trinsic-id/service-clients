// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Streetcred.Portal.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ProofPredicateInfo
    {
        /// <summary>
        /// Initializes a new instance of the ProofPredicateInfo class.
        /// </summary>
        public ProofPredicateInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProofPredicateInfo class.
        /// </summary>
        public ProofPredicateInfo(string pType = default(string), string pValue = default(string), string name = default(string), IList<AttributeFilter> restrictions = default(IList<AttributeFilter>), RevocationInterval nonRevoked = default(RevocationInterval))
        {
            PType = pType;
            PValue = pValue;
            Name = name;
            Restrictions = restrictions;
            NonRevoked = nonRevoked;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "p_type")]
        public string PType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "p_value")]
        public string PValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "restrictions")]
        public IList<AttributeFilter> Restrictions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "non_revoked")]
        public RevocationInterval NonRevoked { get; set; }

    }
}
