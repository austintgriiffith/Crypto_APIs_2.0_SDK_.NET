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
    /// ListUnconfirmedTransactionsByAddressRI
    /// </summary>
    [DataContract(Name = "ListUnconfirmedTransactionsByAddressRI")]
    public partial class ListUnconfirmedTransactionsByAddressRI : IEquatable<ListUnconfirmedTransactionsByAddressRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUnconfirmedTransactionsByAddressRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListUnconfirmedTransactionsByAddressRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListUnconfirmedTransactionsByAddressRI" /> class.
        /// </summary>
        /// <param name="recipients">Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. (required).</param>
        /// <param name="senders">Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. (required).</param>
        /// <param name="timestamp">Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. (required).</param>
        /// <param name="transactionHash">Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions. (required).</param>
        /// <param name="transactionId">Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain. (required).</param>
        /// <param name="blockchainSpecific">blockchainSpecific (required).</param>
        public ListUnconfirmedTransactionsByAddressRI(List<ListUnconfirmedTransactionsByAddressRIRecipients> recipients = default(List<ListUnconfirmedTransactionsByAddressRIRecipients>), List<ListUnconfirmedTransactionsByAddressRISenders> senders = default(List<ListUnconfirmedTransactionsByAddressRISenders>), int timestamp = default(int), string transactionHash = default(string), string transactionId = default(string), ListUnconfirmedTransactionsByAddressRIBS blockchainSpecific = default(ListUnconfirmedTransactionsByAddressRIBS))
        {
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients is a required property for ListUnconfirmedTransactionsByAddressRI and cannot be null");
            }
            this.Recipients = recipients;
            // to ensure "senders" is required (not null)
            if (senders == null)
            {
                throw new ArgumentNullException("senders is a required property for ListUnconfirmedTransactionsByAddressRI and cannot be null");
            }
            this.Senders = senders;
            this.Timestamp = timestamp;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for ListUnconfirmedTransactionsByAddressRI and cannot be null");
            }
            this.TransactionHash = transactionHash;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for ListUnconfirmedTransactionsByAddressRI and cannot be null");
            }
            this.TransactionId = transactionId;
            // to ensure "blockchainSpecific" is required (not null)
            if (blockchainSpecific == null)
            {
                throw new ArgumentNullException("blockchainSpecific is a required property for ListUnconfirmedTransactionsByAddressRI and cannot be null");
            }
            this.BlockchainSpecific = blockchainSpecific;
        }

        /// <summary>
        /// Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.
        /// </summary>
        /// <value>Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<ListUnconfirmedTransactionsByAddressRIRecipients> Recipients { get; set; }

        /// <summary>
        /// Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.
        /// </summary>
        /// <value>Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.</value>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public List<ListUnconfirmedTransactionsByAddressRISenders> Senders { get; set; }

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
        /// Gets or Sets BlockchainSpecific
        /// </summary>
        [DataMember(Name = "blockchainSpecific", IsRequired = true, EmitDefaultValue = false)]
        public ListUnconfirmedTransactionsByAddressRIBS BlockchainSpecific { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListUnconfirmedTransactionsByAddressRI {\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as ListUnconfirmedTransactionsByAddressRI);
        }

        /// <summary>
        /// Returns true if ListUnconfirmedTransactionsByAddressRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListUnconfirmedTransactionsByAddressRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListUnconfirmedTransactionsByAddressRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                if (this.Recipients != null)
                {
                    hashCode = (hashCode * 59) + this.Recipients.GetHashCode();
                }
                if (this.Senders != null)
                {
                    hashCode = (hashCode * 59) + this.Senders.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.BlockchainSpecific != null)
                {
                    hashCode = (hashCode * 59) + this.BlockchainSpecific.GetHashCode();
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
