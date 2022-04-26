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
    /// GetZilliqaAddressDetailsRI
    /// </summary>
    [DataContract(Name = "GetZilliqaAddressDetailsRI")]
    public partial class GetZilliqaAddressDetailsRI : IEquatable<GetZilliqaAddressDetailsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetZilliqaAddressDetailsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetZilliqaAddressDetailsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetZilliqaAddressDetailsRI" /> class.
        /// </summary>
        /// <param name="balance">balance (required).</param>
        /// <param name="incomingTransactionsCount">Defines the received transaction count to the address. (required).</param>
        /// <param name="outgoingTransactionsCount">Defines the sent transaction count from the address. (required).</param>
        /// <param name="transactionsCount">Defines the entire count of the transactions. (required).</param>
        public GetZilliqaAddressDetailsRI(GetZilliqaAddressDetailsRIBalance balance = default(GetZilliqaAddressDetailsRIBalance), int incomingTransactionsCount = default(int), int outgoingTransactionsCount = default(int), int transactionsCount = default(int))
        {
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new ArgumentNullException("balance is a required property for GetZilliqaAddressDetailsRI and cannot be null");
            }
            this.Balance = balance;
            this.IncomingTransactionsCount = incomingTransactionsCount;
            this.OutgoingTransactionsCount = outgoingTransactionsCount;
            this.TransactionsCount = transactionsCount;
        }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = false)]
        public GetZilliqaAddressDetailsRIBalance Balance { get; set; }

        /// <summary>
        /// Defines the received transaction count to the address.
        /// </summary>
        /// <value>Defines the received transaction count to the address.</value>
        [DataMember(Name = "incomingTransactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int IncomingTransactionsCount { get; set; }

        /// <summary>
        /// Defines the sent transaction count from the address.
        /// </summary>
        /// <value>Defines the sent transaction count from the address.</value>
        [DataMember(Name = "outgoingTransactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int OutgoingTransactionsCount { get; set; }

        /// <summary>
        /// Defines the entire count of the transactions.
        /// </summary>
        /// <value>Defines the entire count of the transactions.</value>
        [DataMember(Name = "transactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int TransactionsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetZilliqaAddressDetailsRI {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  IncomingTransactionsCount: ").Append(IncomingTransactionsCount).Append("\n");
            sb.Append("  OutgoingTransactionsCount: ").Append(OutgoingTransactionsCount).Append("\n");
            sb.Append("  TransactionsCount: ").Append(TransactionsCount).Append("\n");
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
            return this.Equals(input as GetZilliqaAddressDetailsRI);
        }

        /// <summary>
        /// Returns true if GetZilliqaAddressDetailsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetZilliqaAddressDetailsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetZilliqaAddressDetailsRI input)
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
                    this.IncomingTransactionsCount == input.IncomingTransactionsCount ||
                    this.IncomingTransactionsCount.Equals(input.IncomingTransactionsCount)
                ) && 
                (
                    this.OutgoingTransactionsCount == input.OutgoingTransactionsCount ||
                    this.OutgoingTransactionsCount.Equals(input.OutgoingTransactionsCount)
                ) && 
                (
                    this.TransactionsCount == input.TransactionsCount ||
                    this.TransactionsCount.Equals(input.TransactionsCount)
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
                hashCode = (hashCode * 59) + this.IncomingTransactionsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.OutgoingTransactionsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TransactionsCount.GetHashCode();
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
