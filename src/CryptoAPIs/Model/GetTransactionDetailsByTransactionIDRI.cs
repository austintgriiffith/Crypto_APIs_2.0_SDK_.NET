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
    /// GetTransactionDetailsByTransactionIDRI
    /// </summary>
    [DataContract(Name = "GetTransactionDetailsByTransactionIDRI")]
    public partial class GetTransactionDetailsByTransactionIDRI : IEquatable<GetTransactionDetailsByTransactionIDRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionDetailsByTransactionIDRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRI" /> class.
        /// </summary>
        /// <param name="index">Represents the index position of the transaction in the specific block. (required).</param>
        /// <param name="minedInBlockHash">Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm..</param>
        /// <param name="minedInBlockHeight">Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block..</param>
        /// <param name="recipients">Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. (required).</param>
        /// <param name="senders">Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. (required).</param>
        /// <param name="timestamp">Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. (required).</param>
        /// <param name="transactionHash">Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions. (required).</param>
        /// <param name="transactionId">Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain. (required).</param>
        /// <param name="fee">fee (required).</param>
        /// <param name="isConfirmed">Defines whether the transaction is mined/confirmed or not. If it is \&quot;false\&quot;, it means the transaction is still in the Mempool waiting to be included in a block. Value \&quot;true\&quot; means that this transaction is already confirmed and included in a block. (required).</param>
        /// <param name="blockchainSpecific">blockchainSpecific (required).</param>
        public GetTransactionDetailsByTransactionIDRI(int index = default(int), string minedInBlockHash = default(string), int minedInBlockHeight = default(int), List<GetTransactionDetailsByTransactionIDRIRecipients> recipients = default(List<GetTransactionDetailsByTransactionIDRIRecipients>), List<GetTransactionDetailsByTransactionIDRISenders> senders = default(List<GetTransactionDetailsByTransactionIDRISenders>), int timestamp = default(int), string transactionHash = default(string), string transactionId = default(string), GetTransactionDetailsByTransactionIDRIFee fee = default(GetTransactionDetailsByTransactionIDRIFee), bool isConfirmed = default(bool), GetTransactionDetailsByTransactionIDRIBS blockchainSpecific = default(GetTransactionDetailsByTransactionIDRIBS))
        {
            this.Index = index;
            // to ensure "recipients" is required (not null)
            this.Recipients = recipients ?? throw new ArgumentNullException("recipients is a required property for GetTransactionDetailsByTransactionIDRI and cannot be null");
            // to ensure "senders" is required (not null)
            this.Senders = senders ?? throw new ArgumentNullException("senders is a required property for GetTransactionDetailsByTransactionIDRI and cannot be null");
            this.Timestamp = timestamp;
            // to ensure "transactionHash" is required (not null)
            this.TransactionHash = transactionHash ?? throw new ArgumentNullException("transactionHash is a required property for GetTransactionDetailsByTransactionIDRI and cannot be null");
            // to ensure "transactionId" is required (not null)
            this.TransactionId = transactionId ?? throw new ArgumentNullException("transactionId is a required property for GetTransactionDetailsByTransactionIDRI and cannot be null");
            // to ensure "fee" is required (not null)
            this.Fee = fee ?? throw new ArgumentNullException("fee is a required property for GetTransactionDetailsByTransactionIDRI and cannot be null");
            this.IsConfirmed = isConfirmed;
            // to ensure "blockchainSpecific" is required (not null)
            this.BlockchainSpecific = blockchainSpecific ?? throw new ArgumentNullException("blockchainSpecific is a required property for GetTransactionDetailsByTransactionIDRI and cannot be null");
            this.MinedInBlockHash = minedInBlockHash;
            this.MinedInBlockHeight = minedInBlockHeight;
        }

        /// <summary>
        /// Represents the index position of the transaction in the specific block.
        /// </summary>
        /// <value>Represents the index position of the transaction in the specific block.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
        /// </summary>
        /// <value>Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.</value>
        [DataMember(Name = "minedInBlockHash", EmitDefaultValue = false)]
        public string MinedInBlockHash { get; set; }

        /// <summary>
        /// Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.
        /// </summary>
        /// <value>Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.</value>
        [DataMember(Name = "minedInBlockHeight", EmitDefaultValue = false)]
        public int MinedInBlockHeight { get; set; }

        /// <summary>
        /// Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.
        /// </summary>
        /// <value>Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIRecipients> Recipients { get; set; }

        /// <summary>
        /// Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.
        /// </summary>
        /// <value>Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.</value>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRISenders> Senders { get; set; }

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
        /// Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain.
        /// </summary>
        /// <value>Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = false)]
        public GetTransactionDetailsByTransactionIDRIFee Fee { get; set; }

        /// <summary>
        /// Defines whether the transaction is mined/confirmed or not. If it is \&quot;false\&quot;, it means the transaction is still in the Mempool waiting to be included in a block. Value \&quot;true\&quot; means that this transaction is already confirmed and included in a block.
        /// </summary>
        /// <value>Defines whether the transaction is mined/confirmed or not. If it is \&quot;false\&quot;, it means the transaction is still in the Mempool waiting to be included in a block. Value \&quot;true\&quot; means that this transaction is already confirmed and included in a block.</value>
        [DataMember(Name = "isConfirmed", IsRequired = true, EmitDefaultValue = true)]
        public bool IsConfirmed { get; set; }

        /// <summary>
        /// Gets or Sets BlockchainSpecific
        /// </summary>
        [DataMember(Name = "blockchainSpecific", IsRequired = true, EmitDefaultValue = false)]
        public GetTransactionDetailsByTransactionIDRIBS BlockchainSpecific { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransactionDetailsByTransactionIDRI {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  MinedInBlockHash: ").Append(MinedInBlockHash).Append("\n");
            sb.Append("  MinedInBlockHeight: ").Append(MinedInBlockHeight).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  IsConfirmed: ").Append(IsConfirmed).Append("\n");
            sb.Append("  BlockchainSpecific: ").Append(BlockchainSpecific).Append("\n");
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
            return this.Equals(input as GetTransactionDetailsByTransactionIDRI);
        }

        /// <summary>
        /// Returns true if GetTransactionDetailsByTransactionIDRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionDetailsByTransactionIDRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionDetailsByTransactionIDRI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.MinedInBlockHash == input.MinedInBlockHash ||
                    (this.MinedInBlockHash != null &&
                    this.MinedInBlockHash.Equals(input.MinedInBlockHash))
                ) && 
                (
                    this.MinedInBlockHeight == input.MinedInBlockHeight ||
                    this.MinedInBlockHeight.Equals(input.MinedInBlockHeight)
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
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.IsConfirmed == input.IsConfirmed ||
                    this.IsConfirmed.Equals(input.IsConfirmed)
                ) && 
                (
                    this.BlockchainSpecific == input.BlockchainSpecific ||
                    (this.BlockchainSpecific != null &&
                    this.BlockchainSpecific.Equals(input.BlockchainSpecific))
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
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.MinedInBlockHash != null)
                    hashCode = hashCode * 59 + this.MinedInBlockHash.GetHashCode();
                hashCode = hashCode * 59 + this.MinedInBlockHeight.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Senders != null)
                    hashCode = hashCode * 59 + this.Senders.GetHashCode();
                hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.TransactionHash != null)
                    hashCode = hashCode * 59 + this.TransactionHash.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                hashCode = hashCode * 59 + this.IsConfirmed.GetHashCode();
                if (this.BlockchainSpecific != null)
                    hashCode = hashCode * 59 + this.BlockchainSpecific.GetHashCode();
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
