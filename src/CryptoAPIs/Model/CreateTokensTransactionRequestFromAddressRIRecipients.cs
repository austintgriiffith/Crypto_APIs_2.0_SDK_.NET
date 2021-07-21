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
    /// CreateTokensTransactionRequestFromAddressRIRecipients
    /// </summary>
    [DataContract(Name = "CreateTokensTransactionRequestFromAddressRI_recipients")]
    public partial class CreateTokensTransactionRequestFromAddressRIRecipients : IEquatable<CreateTokensTransactionRequestFromAddressRIRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokensTransactionRequestFromAddressRIRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTokensTransactionRequestFromAddressRIRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokensTransactionRequestFromAddressRIRecipients" /> class.
        /// </summary>
        /// <param name="address">Defines the destination address. (required).</param>
        /// <param name="amount">Defines the amount sent to the destination address. (required).</param>
        public CreateTokensTransactionRequestFromAddressRIRecipients(string address = default(string), string amount = default(string))
        {
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for CreateTokensTransactionRequestFromAddressRIRecipients and cannot be null");
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount is a required property for CreateTokensTransactionRequestFromAddressRIRecipients and cannot be null");
        }

        /// <summary>
        /// Defines the destination address.
        /// </summary>
        /// <value>Defines the destination address.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Defines the amount sent to the destination address.
        /// </summary>
        /// <value>Defines the amount sent to the destination address.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTokensTransactionRequestFromAddressRIRecipients {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as CreateTokensTransactionRequestFromAddressRIRecipients);
        }

        /// <summary>
        /// Returns true if CreateTokensTransactionRequestFromAddressRIRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTokensTransactionRequestFromAddressRIRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTokensTransactionRequestFromAddressRIRecipients input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
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