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
    /// ActivateBlockchainEventSubscriptionRI
    /// </summary>
    [DataContract(Name = "ActivateBlockchainEventSubscriptionRI")]
    public partial class ActivateBlockchainEventSubscriptionRI : IEquatable<ActivateBlockchainEventSubscriptionRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateBlockchainEventSubscriptionRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivateBlockchainEventSubscriptionRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateBlockchainEventSubscriptionRI" /> class.
        /// </summary>
        /// <param name="address">Represents the address of the transaction, per which the result is returned. (required).</param>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our Documentation. (required).</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;. (required).</param>
        /// <param name="confirmationsCount">Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block. (required).</param>
        /// <param name="createdTimestamp">Defines the specific time/date when the subscription was created in Unix Timestamp. (required).</param>
        /// <param name="eventType">Defines the type of the specific event available for the customer to subscribe to for callback notification. (required).</param>
        /// <param name="isActive">Defines whether the subscription is active or not. Set as boolean. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. (required).</param>
        /// <param name="referenceId">Represents a unique ID used to reference the specific callback subscription. (required).</param>
        /// <param name="transactionId">Represents the unique identification string that defines the transaction. (required).</param>
        public ActivateBlockchainEventSubscriptionRI(string address = default(string), string blockchain = default(string), string callbackSecretKey = default(string), string callbackUrl = default(string), int confirmationsCount = default(int), int createdTimestamp = default(int), string eventType = default(string), bool isActive = default(bool), string network = default(string), string referenceId = default(string), string transactionId = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.Address = address;
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new ArgumentNullException("blockchain is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "callbackSecretKey" is required (not null)
            if (callbackSecretKey == null)
            {
                throw new ArgumentNullException("callbackSecretKey is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.CallbackSecretKey = callbackSecretKey;
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new ArgumentNullException("callbackUrl is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            this.ConfirmationsCount = confirmationsCount;
            this.CreatedTimestamp = createdTimestamp;
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new ArgumentNullException("eventType is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.EventType = eventType;
            this.IsActive = isActive;
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.Network = network;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null)
            {
                throw new ArgumentNullException("referenceId is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.ReferenceId = referenceId;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for ActivateBlockchainEventSubscriptionRI and cannot be null");
            }
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Represents the address of the transaction, per which the result is returned.
        /// </summary>
        /// <value>Represents the address of the transaction, per which the result is returned.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our Documentation.
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our Documentation.</value>
        [DataMember(Name = "callbackSecretKey", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block.
        /// </summary>
        /// <value>Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block.</value>
        [DataMember(Name = "confirmationsCount", IsRequired = true, EmitDefaultValue = false)]
        public int ConfirmationsCount { get; set; }

        /// <summary>
        /// Defines the specific time/date when the subscription was created in Unix Timestamp.
        /// </summary>
        /// <value>Defines the specific time/date when the subscription was created in Unix Timestamp.</value>
        [DataMember(Name = "createdTimestamp", IsRequired = true, EmitDefaultValue = false)]
        public int CreatedTimestamp { get; set; }

        /// <summary>
        /// Defines the type of the specific event available for the customer to subscribe to for callback notification.
        /// </summary>
        /// <value>Defines the type of the specific event available for the customer to subscribe to for callback notification.</value>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Defines whether the subscription is active or not. Set as boolean.
        /// </summary>
        /// <value>Defines whether the subscription is active or not. Set as boolean.</value>
        [DataMember(Name = "isActive", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Represents a unique ID used to reference the specific callback subscription.
        /// </summary>
        /// <value>Represents a unique ID used to reference the specific callback subscription.</value>
        [DataMember(Name = "referenceId", IsRequired = true, EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

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
            sb.Append("class ActivateBlockchainEventSubscriptionRI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  ConfirmationsCount: ").Append(ConfirmationsCount).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(input as ActivateBlockchainEventSubscriptionRI);
        }

        /// <summary>
        /// Returns true if ActivateBlockchainEventSubscriptionRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivateBlockchainEventSubscriptionRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivateBlockchainEventSubscriptionRI input)
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
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
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
                    this.ConfirmationsCount == input.ConfirmationsCount ||
                    this.ConfirmationsCount.Equals(input.ConfirmationsCount)
                ) && 
                (
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp)
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Blockchain != null)
                {
                    hashCode = (hashCode * 59) + this.Blockchain.GetHashCode();
                }
                if (this.CallbackSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackSecretKey.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConfirmationsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedTimestamp.GetHashCode();
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.ReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
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
