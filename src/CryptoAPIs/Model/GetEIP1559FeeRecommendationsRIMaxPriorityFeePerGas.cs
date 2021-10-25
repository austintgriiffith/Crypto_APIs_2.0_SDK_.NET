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
    /// GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas
    /// </summary>
    [DataContract(Name = "GetEIP1559FeeRecommendationsRI_maxPriorityFeePerGas")]
    public partial class GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas : IEquatable<GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas" /> class.
        /// </summary>
        /// <param name="fast">Represents the fast maximum priority fee per gas, calculated from unconfirmed transactions. (required).</param>
        /// <param name="slow">Represents the slow maximum priority fee per gas, calculated from unconfirmed transactions. (required).</param>
        /// <param name="standard">Represents the standard maximum priority fee per gas, calculated from unconfirmed transactions. (required).</param>
        /// <param name="unit">Represents the unit of the maximum priority fee per gas. (required).</param>
        public GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas(string fast = default(string), string slow = default(string), string standard = default(string), string unit = default(string))
        {
            // to ensure "fast" is required (not null)
            if (fast == null) {
                throw new ArgumentNullException("fast is a required property for GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas and cannot be null");
            }
            this.Fast = fast;
            // to ensure "slow" is required (not null)
            if (slow == null) {
                throw new ArgumentNullException("slow is a required property for GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas and cannot be null");
            }
            this.Slow = slow;
            // to ensure "standard" is required (not null)
            if (standard == null) {
                throw new ArgumentNullException("standard is a required property for GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas and cannot be null");
            }
            this.Standard = standard;
            // to ensure "unit" is required (not null)
            if (unit == null) {
                throw new ArgumentNullException("unit is a required property for GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas and cannot be null");
            }
            this.Unit = unit;
        }

        /// <summary>
        /// Represents the fast maximum priority fee per gas, calculated from unconfirmed transactions.
        /// </summary>
        /// <value>Represents the fast maximum priority fee per gas, calculated from unconfirmed transactions.</value>
        [DataMember(Name = "fast", IsRequired = true, EmitDefaultValue = false)]
        public string Fast { get; set; }

        /// <summary>
        /// Represents the slow maximum priority fee per gas, calculated from unconfirmed transactions.
        /// </summary>
        /// <value>Represents the slow maximum priority fee per gas, calculated from unconfirmed transactions.</value>
        [DataMember(Name = "slow", IsRequired = true, EmitDefaultValue = false)]
        public string Slow { get; set; }

        /// <summary>
        /// Represents the standard maximum priority fee per gas, calculated from unconfirmed transactions.
        /// </summary>
        /// <value>Represents the standard maximum priority fee per gas, calculated from unconfirmed transactions.</value>
        [DataMember(Name = "standard", IsRequired = true, EmitDefaultValue = false)]
        public string Standard { get; set; }

        /// <summary>
        /// Represents the unit of the maximum priority fee per gas.
        /// </summary>
        /// <value>Represents the unit of the maximum priority fee per gas.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas {\n");
            sb.Append("  Fast: ").Append(Fast).Append("\n");
            sb.Append("  Slow: ").Append(Slow).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas);
        }

        /// <summary>
        /// Returns true if GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEIP1559FeeRecommendationsRIMaxPriorityFeePerGas input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fast == input.Fast ||
                    (this.Fast != null &&
                    this.Fast.Equals(input.Fast))
                ) && 
                (
                    this.Slow == input.Slow ||
                    (this.Slow != null &&
                    this.Slow.Equals(input.Slow))
                ) && 
                (
                    this.Standard == input.Standard ||
                    (this.Standard != null &&
                    this.Standard.Equals(input.Standard))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Fast != null)
                    hashCode = hashCode * 59 + this.Fast.GetHashCode();
                if (this.Slow != null)
                    hashCode = hashCode * 59 + this.Slow.GetHashCode();
                if (this.Standard != null)
                    hashCode = hashCode * 59 + this.Standard.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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