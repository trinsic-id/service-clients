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

    public partial class DefinitionInfo
    {
        /// <summary>
        /// Initializes a new instance of the DefinitionInfo class.
        /// </summary>
        public DefinitionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefinitionInfo class.
        /// </summary>
        public DefinitionInfo(string name = default(string), string version = default(string), IList<string> attributes = default(IList<string>), bool? supportsRevocation = default(bool?), int? maxCredentialCount = default(int?), string schemaId = default(string), string definitionId = default(string))
        {
            Name = name;
            Version = version;
            Attributes = attributes;
            SupportsRevocation = supportsRevocation;
            MaxCredentialCount = maxCredentialCount;
            SchemaId = schemaId;
            DefinitionId = definitionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IList<string> Attributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportsRevocation")]
        public bool? SupportsRevocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxCredentialCount")]
        public int? MaxCredentialCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaId")]
        public string SchemaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "definitionId")]
        public string DefinitionId { get; set; }

    }
}
