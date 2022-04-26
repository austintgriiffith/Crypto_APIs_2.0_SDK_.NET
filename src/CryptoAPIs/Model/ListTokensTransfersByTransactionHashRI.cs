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
    /// ListTokensTransfersByTransactionHashRI
    /// </summary>
    [DataContract(Name = "ListTokensTransfersByTransactionHashRI")]
    public partial class ListTokensTransfersByTransactionHashRI : IEquatable<ListTokensTransfersByTransactionHashRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTokensTransfersByTransactionHashRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListTokensTransfersByTransactionHashRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTokensTransfersByTransactionHashRI" /> class.
        /// </summary>
        /// <param name="contractAddress">Represents the contract address of the token, which controls its logic. It is not the address that holds the tokens. (required).</param>
        /// <param name="minedInBlockHeight">Defines the block height in which this transaction was confirmed/mined. (required).</param>
        /// <param name="recipientAddress">Defines the address to which the recipient receives the transferred tokens. (required).</param>
        /// <param name="senderAddress">Defines the address from which the sender transfers tokens. (required).</param>
        /// <param name="tokenDecimals">Defines the decimals of the token, i.e. the number of digits that come after the decimal coma of the token. (required).</param>
        /// <param name="tokenName">Defines the token&#39;s name as a string. (required).</param>
        /// <param name="tokenSymbol">Defines the token symbol by which the token contract is known. It is usually 3-4 characters in length. (required).</param>
        /// <param name="tokenType">Defines the specific token type. (required).</param>
        /// <param name="tokensAmount">Defines the token amount of the transfer. (required).</param>
        /// <param name="transactionHash">Represents the hash of the transaction, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. (required).</param>
        /// <param name="transactionTimestamp">Defines the specific time/date when the transaction was created in Unix Timestamp. (required).</param>
        /// <param name="transactionFee">transactionFee (required).</param>
        public ListTokensTransfersByTransactionHashRI(string contractAddress = default(string), int minedInBlockHeight = default(int), string recipientAddress = default(string), string senderAddress = default(string), int tokenDecimals = default(int), string tokenName = default(string), string tokenSymbol = default(string), string tokenType = default(string), string tokensAmount = default(string), string transactionHash = default(string), int transactionTimestamp = default(int), ListTokensTransfersByTransactionHashRITransactionFee transactionFee = default(ListTokensTransfersByTransactionHashRITransactionFee))
        {
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.ContractAddress = contractAddress;
            this.MinedInBlockHeight = minedInBlockHeight;
            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new ArgumentNullException("recipientAddress is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.RecipientAddress = recipientAddress;
            // to ensure "senderAddress" is required (not null)
            if (senderAddress == null)
            {
                throw new ArgumentNullException("senderAddress is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.SenderAddress = senderAddress;
            this.TokenDecimals = tokenDecimals;
            // to ensure "tokenName" is required (not null)
            if (tokenName == null)
            {
                throw new ArgumentNullException("tokenName is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.TokenName = tokenName;
            // to ensure "tokenSymbol" is required (not null)
            if (tokenSymbol == null)
            {
                throw new ArgumentNullException("tokenSymbol is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.TokenSymbol = tokenSymbol;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.TokenType = tokenType;
            // to ensure "tokensAmount" is required (not null)
            if (tokensAmount == null)
            {
                throw new ArgumentNullException("tokensAmount is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.TokensAmount = tokensAmount;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.TransactionHash = transactionHash;
            this.TransactionTimestamp = transactionTimestamp;
            // to ensure "transactionFee" is required (not null)
            if (transactionFee == null)
            {
                throw new ArgumentNullException("transactionFee is a required property for ListTokensTransfersByTransactionHashRI and cannot be null");
            }
            this.TransactionFee = transactionFee;
        }

        /// <summary>
        /// Represents the contract address of the token, which controls its logic. It is not the address that holds the tokens.
        /// </summary>
        /// <value>Represents the contract address of the token, which controls its logic. It is not the address that holds the tokens.</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Defines the block height in which this transaction was confirmed/mined.
        /// </summary>
        /// <value>Defines the block height in which this transaction was confirmed/mined.</value>
        [DataMember(Name = "minedInBlockHeight", IsRequired = true, EmitDefaultValue = false)]
        public int MinedInBlockHeight { get; set; }

        /// <summary>
        /// Defines the address to which the recipient receives the transferred tokens.
        /// </summary>
        /// <value>Defines the address to which the recipient receives the transferred tokens.</value>
        [DataMember(Name = "recipientAddress", IsRequired = true, EmitDefaultValue = false)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Defines the address from which the sender transfers tokens.
        /// </summary>
        /// <value>Defines the address from which the sender transfers tokens.</value>
        [DataMember(Name = "senderAddress", IsRequired = true, EmitDefaultValue = false)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// Defines the decimals of the token, i.e. the number of digits that come after the decimal coma of the token.
        /// </summary>
        /// <value>Defines the decimals of the token, i.e. the number of digits that come after the decimal coma of the token.</value>
        [DataMember(Name = "tokenDecimals", IsRequired = true, EmitDefaultValue = false)]
        public int TokenDecimals { get; set; }

        /// <summary>
        /// Defines the token&#39;s name as a string.
        /// </summary>
        /// <value>Defines the token&#39;s name as a string.</value>
        [DataMember(Name = "tokenName", IsRequired = true, EmitDefaultValue = false)]
        public string TokenName { get; set; }

        /// <summary>
        /// Defines the token symbol by which the token contract is known. It is usually 3-4 characters in length.
        /// </summary>
        /// <value>Defines the token symbol by which the token contract is known. It is usually 3-4 characters in length.</value>
        [DataMember(Name = "tokenSymbol", IsRequired = true, EmitDefaultValue = false)]
        public string TokenSymbol { get; set; }

        /// <summary>
        /// Defines the specific token type.
        /// </summary>
        /// <value>Defines the specific token type.</value>
        [DataMember(Name = "tokenType", IsRequired = true, EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Defines the token amount of the transfer.
        /// </summary>
        /// <value>Defines the token amount of the transfer.</value>
        [DataMember(Name = "tokensAmount", IsRequired = true, EmitDefaultValue = false)]
        public string TokensAmount { get; set; }

        /// <summary>
        /// Represents the hash of the transaction, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
        /// </summary>
        /// <value>Represents the hash of the transaction, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.</value>
        [DataMember(Name = "transactionHash", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Defines the specific time/date when the transaction was created in Unix Timestamp.
        /// </summary>
        /// <value>Defines the specific time/date when the transaction was created in Unix Timestamp.</value>
        [DataMember(Name = "transactionTimestamp", IsRequired = true, EmitDefaultValue = false)]
        public int TransactionTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets TransactionFee
        /// </summary>
        [DataMember(Name = "transactionFee", IsRequired = true, EmitDefaultValue = false)]
        public ListTokensTransfersByTransactionHashRITransactionFee TransactionFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListTokensTransfersByTransactionHashRI {\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  MinedInBlockHeight: ").Append(MinedInBlockHeight).Append("\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
            sb.Append("  TokenDecimals: ").Append(TokenDecimals).Append("\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
            sb.Append("  TokenSymbol: ").Append(TokenSymbol).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  TokensAmount: ").Append(TokensAmount).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  TransactionTimestamp: ").Append(TransactionTimestamp).Append("\n");
            sb.Append("  TransactionFee: ").Append(TransactionFee).Append("\n");
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
            return this.Equals(input as ListTokensTransfersByTransactionHashRI);
        }

        /// <summary>
        /// Returns true if ListTokensTransfersByTransactionHashRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTokensTransfersByTransactionHashRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTokensTransfersByTransactionHashRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.MinedInBlockHeight == input.MinedInBlockHeight ||
                    this.MinedInBlockHeight.Equals(input.MinedInBlockHeight)
                ) && 
                (
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.SenderAddress == input.SenderAddress ||
                    (this.SenderAddress != null &&
                    this.SenderAddress.Equals(input.SenderAddress))
                ) && 
                (
                    this.TokenDecimals == input.TokenDecimals ||
                    this.TokenDecimals.Equals(input.TokenDecimals)
                ) && 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
                ) && 
                (
                    this.TokenSymbol == input.TokenSymbol ||
                    (this.TokenSymbol != null &&
                    this.TokenSymbol.Equals(input.TokenSymbol))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.TokensAmount == input.TokensAmount ||
                    (this.TokensAmount != null &&
                    this.TokensAmount.Equals(input.TokensAmount))
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.TransactionTimestamp == input.TransactionTimestamp ||
                    this.TransactionTimestamp.Equals(input.TransactionTimestamp)
                ) && 
                (
                    this.TransactionFee == input.TransactionFee ||
                    (this.TransactionFee != null &&
                    this.TransactionFee.Equals(input.TransactionFee))
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
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinedInBlockHeight.GetHashCode();
                if (this.RecipientAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientAddress.GetHashCode();
                }
                if (this.SenderAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SenderAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenDecimals.GetHashCode();
                if (this.TokenName != null)
                {
                    hashCode = (hashCode * 59) + this.TokenName.GetHashCode();
                }
                if (this.TokenSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.TokenSymbol.GetHashCode();
                }
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                }
                if (this.TokensAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TokensAmount.GetHashCode();
                }
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransactionTimestamp.GetHashCode();
                if (this.TransactionFee != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionFee.GetHashCode();
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
