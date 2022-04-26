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
    /// GetTransactionRequestDetailsRIRecipients
    /// </summary>
    [DataContract(Name = "GetTransactionRequestDetailsRI_recipients")]
    public partial class GetTransactionRequestDetailsRIRecipients : IEquatable<GetTransactionRequestDetailsRIRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionRequestDetailsRIRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionRequestDetailsRIRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionRequestDetailsRIRecipients" /> class.
        /// </summary>
        /// <param name="address">The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient. (required).</param>
        /// <param name="addressTag">Defines a specific Tag that is an additional XRP address feature. It helps identify a transaction recipient beyond a wallet address. The tag that was encoded into the x-Address along with the Classic Address..</param>
        /// <param name="amount">Represents the amount received to this address. (required).</param>
        /// <param name="classicAddress">Represents the public address, which is a compressed and shortened form of a public key. A classic address is shown when the destination address is an x-Address..</param>
        /// <param name="unit">Defines the unit of the amount. (required).</param>
        public GetTransactionRequestDetailsRIRecipients(string address = default(string), int addressTag = default(int), string amount = default(string), string classicAddress = default(string), string unit = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for GetTransactionRequestDetailsRIRecipients and cannot be null");
            }
            this.Address = address;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for GetTransactionRequestDetailsRIRecipients and cannot be null");
            }
            this.Amount = amount;
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new ArgumentNullException("unit is a required property for GetTransactionRequestDetailsRIRecipients and cannot be null");
            }
            this.Unit = unit;
            this.AddressTag = addressTag;
            this.ClassicAddress = classicAddress;
        }

        /// <summary>
        /// The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient.
        /// </summary>
        /// <value>The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Defines a specific Tag that is an additional XRP address feature. It helps identify a transaction recipient beyond a wallet address. The tag that was encoded into the x-Address along with the Classic Address.
        /// </summary>
        /// <value>Defines a specific Tag that is an additional XRP address feature. It helps identify a transaction recipient beyond a wallet address. The tag that was encoded into the x-Address along with the Classic Address.</value>
        [DataMember(Name = "addressTag", EmitDefaultValue = false)]
        public int AddressTag { get; set; }

        /// <summary>
        /// Represents the amount received to this address.
        /// </summary>
        /// <value>Represents the amount received to this address.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Represents the public address, which is a compressed and shortened form of a public key. A classic address is shown when the destination address is an x-Address.
        /// </summary>
        /// <value>Represents the public address, which is a compressed and shortened form of a public key. A classic address is shown when the destination address is an x-Address.</value>
        [DataMember(Name = "classicAddress", EmitDefaultValue = false)]
        public string ClassicAddress { get; set; }

        /// <summary>
        /// Defines the unit of the amount.
        /// </summary>
        /// <value>Defines the unit of the amount.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionRequestDetailsRIRecipients {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressTag: ").Append(AddressTag).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ClassicAddress: ").Append(ClassicAddress).Append("\n");
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
            return this.Equals(input as GetTransactionRequestDetailsRIRecipients);
        }

        /// <summary>
        /// Returns true if GetTransactionRequestDetailsRIRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionRequestDetailsRIRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionRequestDetailsRIRecipients input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressTag == input.AddressTag ||
                    this.AddressTag.Equals(input.AddressTag)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ClassicAddress == input.ClassicAddress ||
                    (this.ClassicAddress != null &&
                    this.ClassicAddress.Equals(input.ClassicAddress))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AddressTag.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ClassicAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ClassicAddress.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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
