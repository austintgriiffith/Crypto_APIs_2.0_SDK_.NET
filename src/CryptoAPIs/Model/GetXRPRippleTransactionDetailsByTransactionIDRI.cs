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
    /// GetXRPRippleTransactionDetailsByTransactionIDRI
    /// </summary>
    [DataContract(Name = "GetXRPRippleTransactionDetailsByTransactionIDRI")]
    public partial class GetXRPRippleTransactionDetailsByTransactionIDRI : IEquatable<GetXRPRippleTransactionDetailsByTransactionIDRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetXRPRippleTransactionDetailsByTransactionIDRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetXRPRippleTransactionDetailsByTransactionIDRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetXRPRippleTransactionDetailsByTransactionIDRI" /> class.
        /// </summary>
        /// <param name="additionalData">Represents additional data that may be needed. (required).</param>
        /// <param name="destinationTag">destinationTag.</param>
        /// <param name="index">Defines the index of the transaction, i.e. the consecutive place it takes in the blockchain. (required).</param>
        /// <param name="minedInBlockHash">Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. (required).</param>
        /// <param name="minedInBlockHeight">Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block. (required).</param>
        /// <param name="offer">offer (required).</param>
        /// <param name="receive">receive (required).</param>
        /// <param name="recipients">Represents an object of addresses that receive the transactions. (required).</param>
        /// <param name="senders">Represents an object of addresses that provide the funds. (required).</param>
        /// <param name="sequence">Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime. (required).</param>
        /// <param name="status">Defines the status of the transaction..</param>
        /// <param name="timestamp">Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. (required).</param>
        /// <param name="transactionHash">Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions. (required).</param>
        /// <param name="type">Defines the type of the transaction. (required).</param>
        /// <param name="fee">fee (required).</param>
        /// <param name="value">value (required).</param>
        public GetXRPRippleTransactionDetailsByTransactionIDRI(string additionalData = default(string), long destinationTag = default(long), string index = default(string), string minedInBlockHash = default(string), string minedInBlockHeight = default(string), GetXRPRippleTransactionDetailsByTransactionIDRIOffer offer = default(GetXRPRippleTransactionDetailsByTransactionIDRIOffer), GetXRPRippleTransactionDetailsByTransactionIDRIReceive receive = default(GetXRPRippleTransactionDetailsByTransactionIDRIReceive), List<GetXRPRippleTransactionDetailsByTransactionIDRIRecipients> recipients = default(List<GetXRPRippleTransactionDetailsByTransactionIDRIRecipients>), List<GetXRPRippleTransactionDetailsByTransactionIDRISenders> senders = default(List<GetXRPRippleTransactionDetailsByTransactionIDRISenders>), long sequence = default(long), string status = default(string), int timestamp = default(int), string transactionHash = default(string), string type = default(string), GetXRPRippleTransactionDetailsByTransactionIDRIFee fee = default(GetXRPRippleTransactionDetailsByTransactionIDRIFee), GetXRPRippleTransactionDetailsByTransactionIDRIValue value = default(GetXRPRippleTransactionDetailsByTransactionIDRIValue))
        {
            // to ensure "additionalData" is required (not null)
            if (additionalData == null)
            {
                throw new ArgumentNullException("additionalData is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.AdditionalData = additionalData;
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new ArgumentNullException("index is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Index = index;
            // to ensure "minedInBlockHash" is required (not null)
            if (minedInBlockHash == null)
            {
                throw new ArgumentNullException("minedInBlockHash is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.MinedInBlockHash = minedInBlockHash;
            // to ensure "minedInBlockHeight" is required (not null)
            if (minedInBlockHeight == null)
            {
                throw new ArgumentNullException("minedInBlockHeight is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.MinedInBlockHeight = minedInBlockHeight;
            // to ensure "offer" is required (not null)
            if (offer == null)
            {
                throw new ArgumentNullException("offer is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Offer = offer;
            // to ensure "receive" is required (not null)
            if (receive == null)
            {
                throw new ArgumentNullException("receive is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Receive = receive;
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Recipients = recipients;
            // to ensure "senders" is required (not null)
            if (senders == null)
            {
                throw new ArgumentNullException("senders is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Senders = senders;
            this.Sequence = sequence;
            this.Timestamp = timestamp;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.TransactionHash = transactionHash;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Type = type;
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new ArgumentNullException("fee is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Fee = fee;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for GetXRPRippleTransactionDetailsByTransactionIDRI and cannot be null");
            }
            this.Value = value;
            this.DestinationTag = destinationTag;
            this.Status = status;
        }

        /// <summary>
        /// Represents additional data that may be needed.
        /// </summary>
        /// <value>Represents additional data that may be needed.</value>
        [DataMember(Name = "additionalData", IsRequired = true, EmitDefaultValue = false)]
        public string AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets DestinationTag
        /// </summary>
        [DataMember(Name = "destinationTag", EmitDefaultValue = false)]
        public long DestinationTag { get; set; }

        /// <summary>
        /// Defines the index of the transaction, i.e. the consecutive place it takes in the blockchain.
        /// </summary>
        /// <value>Defines the index of the transaction, i.e. the consecutive place it takes in the blockchain.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = false)]
        public string Index { get; set; }

        /// <summary>
        /// Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
        /// </summary>
        /// <value>Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.</value>
        [DataMember(Name = "minedInBlockHash", IsRequired = true, EmitDefaultValue = false)]
        public string MinedInBlockHash { get; set; }

        /// <summary>
        /// Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.
        /// </summary>
        /// <value>Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.</value>
        [DataMember(Name = "minedInBlockHeight", IsRequired = true, EmitDefaultValue = false)]
        public string MinedInBlockHeight { get; set; }

        /// <summary>
        /// Gets or Sets Offer
        /// </summary>
        [DataMember(Name = "offer", IsRequired = true, EmitDefaultValue = false)]
        public GetXRPRippleTransactionDetailsByTransactionIDRIOffer Offer { get; set; }

        /// <summary>
        /// Gets or Sets Receive
        /// </summary>
        [DataMember(Name = "receive", IsRequired = true, EmitDefaultValue = false)]
        public GetXRPRippleTransactionDetailsByTransactionIDRIReceive Receive { get; set; }

        /// <summary>
        /// Represents an object of addresses that receive the transactions.
        /// </summary>
        /// <value>Represents an object of addresses that receive the transactions.</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<GetXRPRippleTransactionDetailsByTransactionIDRIRecipients> Recipients { get; set; }

        /// <summary>
        /// Represents an object of addresses that provide the funds.
        /// </summary>
        /// <value>Represents an object of addresses that provide the funds.</value>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public List<GetXRPRippleTransactionDetailsByTransactionIDRISenders> Senders { get; set; }

        /// <summary>
        /// Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime.
        /// </summary>
        /// <value>Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime.</value>
        [DataMember(Name = "sequence", IsRequired = true, EmitDefaultValue = false)]
        public long Sequence { get; set; }

        /// <summary>
        /// Defines the status of the transaction.
        /// </summary>
        /// <value>Defines the status of the transaction.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.
        /// </summary>
        /// <value>Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions.
        /// </summary>
        /// <value>Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions.</value>
        [DataMember(Name = "transactionHash", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Defines the type of the transaction.
        /// </summary>
        /// <value>Defines the type of the transaction.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = false)]
        public GetXRPRippleTransactionDetailsByTransactionIDRIFee Fee { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public GetXRPRippleTransactionDetailsByTransactionIDRIValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetXRPRippleTransactionDetailsByTransactionIDRI {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  DestinationTag: ").Append(DestinationTag).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  MinedInBlockHash: ").Append(MinedInBlockHash).Append("\n");
            sb.Append("  MinedInBlockHeight: ").Append(MinedInBlockHeight).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  Receive: ").Append(Receive).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as GetXRPRippleTransactionDetailsByTransactionIDRI);
        }

        /// <summary>
        /// Returns true if GetXRPRippleTransactionDetailsByTransactionIDRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetXRPRippleTransactionDetailsByTransactionIDRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetXRPRippleTransactionDetailsByTransactionIDRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    (this.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData))
                ) && 
                (
                    this.DestinationTag == input.DestinationTag ||
                    this.DestinationTag.Equals(input.DestinationTag)
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.MinedInBlockHash == input.MinedInBlockHash ||
                    (this.MinedInBlockHash != null &&
                    this.MinedInBlockHash.Equals(input.MinedInBlockHash))
                ) && 
                (
                    this.MinedInBlockHeight == input.MinedInBlockHeight ||
                    (this.MinedInBlockHeight != null &&
                    this.MinedInBlockHeight.Equals(input.MinedInBlockHeight))
                ) && 
                (
                    this.Offer == input.Offer ||
                    (this.Offer != null &&
                    this.Offer.Equals(input.Offer))
                ) && 
                (
                    this.Receive == input.Receive ||
                    (this.Receive != null &&
                    this.Receive.Equals(input.Receive))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Senders == input.Senders ||
                    this.Senders != null &&
                    input.Senders != null &&
                    this.Senders.SequenceEqual(input.Senders)
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    this.Sequence.Equals(input.Sequence)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DestinationTag.GetHashCode();
                if (this.Index != null)
                {
                    hashCode = (hashCode * 59) + this.Index.GetHashCode();
                }
                if (this.MinedInBlockHash != null)
                {
                    hashCode = (hashCode * 59) + this.MinedInBlockHash.GetHashCode();
                }
                if (this.MinedInBlockHeight != null)
                {
                    hashCode = (hashCode * 59) + this.MinedInBlockHeight.GetHashCode();
                }
                if (this.Offer != null)
                {
                    hashCode = (hashCode * 59) + this.Offer.GetHashCode();
                }
                if (this.Receive != null)
                {
                    hashCode = (hashCode * 59) + this.Receive.GetHashCode();
                }
                if (this.Recipients != null)
                {
                    hashCode = (hashCode * 59) + this.Recipients.GetHashCode();
                }
                if (this.Senders != null)
                {
                    hashCode = (hashCode * 59) + this.Senders.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Sequence.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
