/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: developers@cryptoapis.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CryptoAPIs.Client.OpenAPIDateConverter;

namespace CryptoAPIs.Model
{
    /// <summary>
    /// Ethereum Token
    /// </summary>
    [DataContract(Name = "DeleteAutomaticTokensForwardingRITSET")]
    public partial class DeleteAutomaticTokensForwardingRITSET : IEquatable<DeleteAutomaticTokensForwardingRITSET>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAutomaticTokensForwardingRITSET" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteAutomaticTokensForwardingRITSET() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAutomaticTokensForwardingRITSET" /> class.
        /// </summary>
        /// <param name="contractAddress">Represents the specific &#x60;contractAddress&#x60; of the Token that will be forwarded. (required).</param>
        public DeleteAutomaticTokensForwardingRITSET(string contractAddress = default(string))
        {
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for DeleteAutomaticTokensForwardingRITSET and cannot be null");
            }
            this.ContractAddress = contractAddress;
        }

        /// <summary>
        /// Represents the specific &#x60;contractAddress&#x60; of the Token that will be forwarded.
        /// </summary>
        /// <value>Represents the specific &#x60;contractAddress&#x60; of the Token that will be forwarded.</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteAutomaticTokensForwardingRITSET {\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAutomaticTokensForwardingRITSET);
        }

        /// <summary>
        /// Returns true if DeleteAutomaticTokensForwardingRITSET instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteAutomaticTokensForwardingRITSET to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteAutomaticTokensForwardingRITSET input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
