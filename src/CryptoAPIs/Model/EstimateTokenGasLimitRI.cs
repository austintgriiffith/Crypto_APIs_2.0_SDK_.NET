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
    /// EstimateTokenGasLimitRI
    /// </summary>
    [DataContract(Name = "EstimateTokenGasLimitRI")]
    public partial class EstimateTokenGasLimitRI : IEquatable<EstimateTokenGasLimitRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenGasLimitRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimateTokenGasLimitRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenGasLimitRI" /> class.
        /// </summary>
        /// <param name="gasLimit">Represents the amount of gas used by this specific transaction alone. (required).</param>
        public EstimateTokenGasLimitRI(string gasLimit = default(string))
        {
            // to ensure "gasLimit" is required (not null)
            if (gasLimit == null)
            {
                throw new ArgumentNullException("gasLimit is a required property for EstimateTokenGasLimitRI and cannot be null");
            }
            this.GasLimit = gasLimit;
        }

        /// <summary>
        /// Represents the amount of gas used by this specific transaction alone.
        /// </summary>
        /// <value>Represents the amount of gas used by this specific transaction alone.</value>
        [DataMember(Name = "gasLimit", IsRequired = true, EmitDefaultValue = false)]
        public string GasLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateTokenGasLimitRI {\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
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
            return this.Equals(input as EstimateTokenGasLimitRI);
        }

        /// <summary>
        /// Returns true if EstimateTokenGasLimitRI instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateTokenGasLimitRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateTokenGasLimitRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
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
                if (this.GasLimit != null)
                {
                    hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
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
