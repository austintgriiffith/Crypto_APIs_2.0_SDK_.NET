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
    /// MinedTransactionRBDataItem
    /// </summary>
    [DataContract(Name = "MinedTransactionRB_data_item")]
    public partial class MinedTransactionRBDataItem : IEquatable<MinedTransactionRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinedTransactionRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MinedTransactionRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MinedTransactionRBDataItem" /> class.
        /// </summary>
        /// <param name="allowDuplicates">Specifies a flag that permits or denies the creation of duplicate addresses..</param>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security)..</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;. (required).</param>
        /// <param name="transactionId">Represents the unique identification string that defines the transaction. (required).</param>
        public MinedTransactionRBDataItem(bool allowDuplicates = default(bool), string callbackSecretKey = default(string), string callbackUrl = default(string), string transactionId = default(string))
        {
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new ArgumentNullException("callbackUrl is a required property for MinedTransactionRBDataItem and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for MinedTransactionRBDataItem and cannot be null");
            }
            this.TransactionId = transactionId;
            this.AllowDuplicates = allowDuplicates;
            this.CallbackSecretKey = callbackSecretKey;
        }

        /// <summary>
        /// Specifies a flag that permits or denies the creation of duplicate addresses.
        /// </summary>
        /// <value>Specifies a flag that permits or denies the creation of duplicate addresses.</value>
        [DataMember(Name = "allowDuplicates", EmitDefaultValue = true)]
        public bool AllowDuplicates { get; set; }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Represents the unique identification string that defines the transaction.
        /// </summary>
        /// <value>Represents the unique identification string that defines the transaction.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MinedTransactionRBDataItem {\n");
            sb.Append("  AllowDuplicates: ").Append(AllowDuplicates).Append("\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as MinedTransactionRBDataItem);
        }

        /// <summary>
        /// Returns true if MinedTransactionRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MinedTransactionRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinedTransactionRBDataItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowDuplicates == input.AllowDuplicates ||
                    this.AllowDuplicates.Equals(input.AllowDuplicates)
                ) && 
                (
                    this.CallbackSecretKey == input.CallbackSecretKey ||
                    (this.CallbackSecretKey != null &&
                    this.CallbackSecretKey.Equals(input.CallbackSecretKey))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                hashCode = (hashCode * 59) + this.AllowDuplicates.GetHashCode();
                if (this.CallbackSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackSecretKey.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
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
