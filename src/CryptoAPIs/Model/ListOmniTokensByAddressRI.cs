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
    /// ListOmniTokensByAddressRI
    /// </summary>
    [DataContract(Name = "ListOmniTokensByAddressRI")]
    public partial class ListOmniTokensByAddressRI : IEquatable<ListOmniTokensByAddressRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOmniTokensByAddressRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListOmniTokensByAddressRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOmniTokensByAddressRI" /> class.
        /// </summary>
        /// <param name="balance">Defines the balance of the Omni tokens to send in the address. (required).</param>
        /// <param name="frozen">Defines the amount frozen by the issuer (applies to managed properties only). (required).</param>
        /// <param name="name">Defines the name of the Omni tokens to send. (required).</param>
        /// <param name="propertyId">Represents the identifier of the tokens to send. (required).</param>
        /// <param name="reserved">Represents the amount reserved by sell offers and accepts. (required).</param>
        public ListOmniTokensByAddressRI(string balance = default(string), string frozen = default(string), string name = default(string), int propertyId = default(int), string reserved = default(string))
        {
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new ArgumentNullException("balance is a required property for ListOmniTokensByAddressRI and cannot be null");
            }
            this.Balance = balance;
            // to ensure "frozen" is required (not null)
            if (frozen == null)
            {
                throw new ArgumentNullException("frozen is a required property for ListOmniTokensByAddressRI and cannot be null");
            }
            this.Frozen = frozen;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ListOmniTokensByAddressRI and cannot be null");
            }
            this.Name = name;
            this.PropertyId = propertyId;
            // to ensure "reserved" is required (not null)
            if (reserved == null)
            {
                throw new ArgumentNullException("reserved is a required property for ListOmniTokensByAddressRI and cannot be null");
            }
            this.Reserved = reserved;
        }

        /// <summary>
        /// Defines the balance of the Omni tokens to send in the address.
        /// </summary>
        /// <value>Defines the balance of the Omni tokens to send in the address.</value>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = false)]
        public string Balance { get; set; }

        /// <summary>
        /// Defines the amount frozen by the issuer (applies to managed properties only).
        /// </summary>
        /// <value>Defines the amount frozen by the issuer (applies to managed properties only).</value>
        [DataMember(Name = "frozen", IsRequired = true, EmitDefaultValue = false)]
        public string Frozen { get; set; }

        /// <summary>
        /// Defines the name of the Omni tokens to send.
        /// </summary>
        /// <value>Defines the name of the Omni tokens to send.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Represents the identifier of the tokens to send.
        /// </summary>
        /// <value>Represents the identifier of the tokens to send.</value>
        [DataMember(Name = "propertyId", IsRequired = true, EmitDefaultValue = false)]
        public int PropertyId { get; set; }

        /// <summary>
        /// Represents the amount reserved by sell offers and accepts.
        /// </summary>
        /// <value>Represents the amount reserved by sell offers and accepts.</value>
        [DataMember(Name = "reserved", IsRequired = true, EmitDefaultValue = false)]
        public string Reserved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListOmniTokensByAddressRI {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Frozen: ").Append(Frozen).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  Reserved: ").Append(Reserved).Append("\n");
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
            return this.Equals(input as ListOmniTokensByAddressRI);
        }

        /// <summary>
        /// Returns true if ListOmniTokensByAddressRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOmniTokensByAddressRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOmniTokensByAddressRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Frozen == input.Frozen ||
                    (this.Frozen != null &&
                    this.Frozen.Equals(input.Frozen))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyId == input.PropertyId ||
                    this.PropertyId.Equals(input.PropertyId)
                ) && 
                (
                    this.Reserved == input.Reserved ||
                    (this.Reserved != null &&
                    this.Reserved.Equals(input.Reserved))
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
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.Frozen != null)
                {
                    hashCode = (hashCode * 59) + this.Frozen.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PropertyId.GetHashCode();
                if (this.Reserved != null)
                {
                    hashCode = (hashCode * 59) + this.Reserved.GetHashCode();
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
