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
    /// CreateCoinsTransactionRequestFromWalletRBDataItem
    /// </summary>
    [DataContract(Name = "CreateCoinsTransactionRequestFromWalletRB_data_item")]
    public partial class CreateCoinsTransactionRequestFromWalletRBDataItem : IEquatable<CreateCoinsTransactionRequestFromWalletRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeePriorityEnum
        {
            /// <summary>
            /// Enum Slow for value: slow
            /// </summary>
            [EnumMember(Value = "slow")]
            Slow = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2,

            /// <summary>
            /// Enum Fast for value: fast
            /// </summary>
            [EnumMember(Value = "fast")]
            Fast = 3

        }


        /// <summary>
        /// Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
        [DataMember(Name = "feePriority", IsRequired = true, EmitDefaultValue = false)]
        public FeePriorityEnum FeePriority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinsTransactionRequestFromWalletRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCoinsTransactionRequestFromWalletRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinsTransactionRequestFromWalletRBDataItem" /> class.
        /// </summary>
        /// <param name="destinations">Defines the destination of the transaction, whether it is incoming or outgoing. (required).</param>
        /// <param name="feePriority">Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;. (required).</param>
        public CreateCoinsTransactionRequestFromWalletRBDataItem(List<CreateCoinsTransactionRequestFromWalletRBDataItemDestinations> destinations = default(List<CreateCoinsTransactionRequestFromWalletRBDataItemDestinations>), FeePriorityEnum feePriority = default(FeePriorityEnum))
        {
            // to ensure "destinations" is required (not null)
            this.Destinations = destinations ?? throw new ArgumentNullException("destinations is a required property for CreateCoinsTransactionRequestFromWalletRBDataItem and cannot be null");
            this.FeePriority = feePriority;
        }

        /// <summary>
        /// Defines the destination of the transaction, whether it is incoming or outgoing.
        /// </summary>
        /// <value>Defines the destination of the transaction, whether it is incoming or outgoing.</value>
        [DataMember(Name = "destinations", IsRequired = true, EmitDefaultValue = false)]
        public List<CreateCoinsTransactionRequestFromWalletRBDataItemDestinations> Destinations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCoinsTransactionRequestFromWalletRBDataItem {\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  FeePriority: ").Append(FeePriority).Append("\n");
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
            return this.Equals(input as CreateCoinsTransactionRequestFromWalletRBDataItem);
        }

        /// <summary>
        /// Returns true if CreateCoinsTransactionRequestFromWalletRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCoinsTransactionRequestFromWalletRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCoinsTransactionRequestFromWalletRBDataItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.FeePriority == input.FeePriority ||
                    this.FeePriority.Equals(input.FeePriority)
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
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                hashCode = hashCode * 59 + this.FeePriority.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}