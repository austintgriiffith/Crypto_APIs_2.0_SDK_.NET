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
    /// Defines an &#x60;item&#x60; as one result.
    /// </summary>
    [DataContract(Name = "TokensForwardingSuccess_data_item")]
    public partial class TokensForwardingSuccessDataItem : IEquatable<TokensForwardingSuccessDataItem>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of token sent with the transaction, e.g. ERC 20.
        /// </summary>
        /// <value>Defines the type of token sent with the transaction, e.g. ERC 20.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TokenTypeEnum
        {
            /// <summary>
            /// Enum ERC20 for value: ERC-20
            /// </summary>
            [EnumMember(Value = "ERC-20")]
            ERC20 = 1,

            /// <summary>
            /// Enum ERC721 for value: ERC-721
            /// </summary>
            [EnumMember(Value = "ERC-721")]
            ERC721 = 2,

            /// <summary>
            /// Enum OMNI for value: OMNI
            /// </summary>
            [EnumMember(Value = "OMNI")]
            OMNI = 3

        }


        /// <summary>
        /// Defines the type of token sent with the transaction, e.g. ERC 20.
        /// </summary>
        /// <value>Defines the type of token sent with the transaction, e.g. ERC 20.</value>
        [DataMember(Name = "tokenType", IsRequired = true, EmitDefaultValue = false)]
        public TokenTypeEnum TokenType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensForwardingSuccessDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokensForwardingSuccessDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensForwardingSuccessDataItem" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. (required).</param>
        /// <param name="fromAddress">Represents the hash of the address that provides the tokens. (required).</param>
        /// <param name="toAddress">Represents the hash of the address to forward the tokens to. (required).</param>
        /// <param name="spentFeesAmount">Represents the amount of the fee spent for the tokens to be forwarded. (required).</param>
        /// <param name="spentFeesUnit">Represents the unit of the fee spent for the tokens to be forwarded, e.g. BTC. (required).</param>
        /// <param name="triggerTransactionId">Defines the unique Transaction ID that triggered the token forwarding. (required).</param>
        /// <param name="forwardingTransactionId">Defines the unique Transaction ID that forwarded the tokens. (required).</param>
        /// <param name="tokenType">Defines the type of token sent with the transaction, e.g. ERC 20. (required).</param>
        /// <param name="token">token (required).</param>
        public TokensForwardingSuccessDataItem(string blockchain = default(string), string network = default(string), string fromAddress = default(string), string toAddress = default(string), string spentFeesAmount = default(string), string spentFeesUnit = default(string), string triggerTransactionId = default(string), string forwardingTransactionId = default(string), TokenTypeEnum tokenType = default(TokenTypeEnum), TokensForwardingSuccessToken token = default(TokensForwardingSuccessToken))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new ArgumentNullException("blockchain is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.Network = network;
            // to ensure "fromAddress" is required (not null)
            if (fromAddress == null)
            {
                throw new ArgumentNullException("fromAddress is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.FromAddress = fromAddress;
            // to ensure "toAddress" is required (not null)
            if (toAddress == null)
            {
                throw new ArgumentNullException("toAddress is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.ToAddress = toAddress;
            // to ensure "spentFeesAmount" is required (not null)
            if (spentFeesAmount == null)
            {
                throw new ArgumentNullException("spentFeesAmount is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.SpentFeesAmount = spentFeesAmount;
            // to ensure "spentFeesUnit" is required (not null)
            if (spentFeesUnit == null)
            {
                throw new ArgumentNullException("spentFeesUnit is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.SpentFeesUnit = spentFeesUnit;
            // to ensure "triggerTransactionId" is required (not null)
            if (triggerTransactionId == null)
            {
                throw new ArgumentNullException("triggerTransactionId is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.TriggerTransactionId = triggerTransactionId;
            // to ensure "forwardingTransactionId" is required (not null)
            if (forwardingTransactionId == null)
            {
                throw new ArgumentNullException("forwardingTransactionId is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.ForwardingTransactionId = forwardingTransactionId;
            this.TokenType = tokenType;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for TokensForwardingSuccessDataItem and cannot be null");
            }
            this.Token = token;
        }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Represents the hash of the address that provides the tokens.
        /// </summary>
        /// <value>Represents the hash of the address that provides the tokens.</value>
        [DataMember(Name = "fromAddress", IsRequired = true, EmitDefaultValue = false)]
        public string FromAddress { get; set; }

        /// <summary>
        /// Represents the hash of the address to forward the tokens to.
        /// </summary>
        /// <value>Represents the hash of the address to forward the tokens to.</value>
        [DataMember(Name = "toAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// Represents the amount of the fee spent for the tokens to be forwarded.
        /// </summary>
        /// <value>Represents the amount of the fee spent for the tokens to be forwarded.</value>
        [DataMember(Name = "spentFeesAmount", IsRequired = true, EmitDefaultValue = false)]
        public string SpentFeesAmount { get; set; }

        /// <summary>
        /// Represents the unit of the fee spent for the tokens to be forwarded, e.g. BTC.
        /// </summary>
        /// <value>Represents the unit of the fee spent for the tokens to be forwarded, e.g. BTC.</value>
        [DataMember(Name = "spentFeesUnit", IsRequired = true, EmitDefaultValue = false)]
        public string SpentFeesUnit { get; set; }

        /// <summary>
        /// Defines the unique Transaction ID that triggered the token forwarding.
        /// </summary>
        /// <value>Defines the unique Transaction ID that triggered the token forwarding.</value>
        [DataMember(Name = "triggerTransactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TriggerTransactionId { get; set; }

        /// <summary>
        /// Defines the unique Transaction ID that forwarded the tokens.
        /// </summary>
        /// <value>Defines the unique Transaction ID that forwarded the tokens.</value>
        [DataMember(Name = "forwardingTransactionId", IsRequired = true, EmitDefaultValue = false)]
        public string ForwardingTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = false)]
        public TokensForwardingSuccessToken Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokensForwardingSuccessDataItem {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  SpentFeesAmount: ").Append(SpentFeesAmount).Append("\n");
            sb.Append("  SpentFeesUnit: ").Append(SpentFeesUnit).Append("\n");
            sb.Append("  TriggerTransactionId: ").Append(TriggerTransactionId).Append("\n");
            sb.Append("  ForwardingTransactionId: ").Append(ForwardingTransactionId).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as TokensForwardingSuccessDataItem);
        }

        /// <summary>
        /// Returns true if TokensForwardingSuccessDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensForwardingSuccessDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensForwardingSuccessDataItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.ToAddress == input.ToAddress ||
                    (this.ToAddress != null &&
                    this.ToAddress.Equals(input.ToAddress))
                ) && 
                (
                    this.SpentFeesAmount == input.SpentFeesAmount ||
                    (this.SpentFeesAmount != null &&
                    this.SpentFeesAmount.Equals(input.SpentFeesAmount))
                ) && 
                (
                    this.SpentFeesUnit == input.SpentFeesUnit ||
                    (this.SpentFeesUnit != null &&
                    this.SpentFeesUnit.Equals(input.SpentFeesUnit))
                ) && 
                (
                    this.TriggerTransactionId == input.TriggerTransactionId ||
                    (this.TriggerTransactionId != null &&
                    this.TriggerTransactionId.Equals(input.TriggerTransactionId))
                ) && 
                (
                    this.ForwardingTransactionId == input.ForwardingTransactionId ||
                    (this.ForwardingTransactionId != null &&
                    this.ForwardingTransactionId.Equals(input.ForwardingTransactionId))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    this.TokenType.Equals(input.TokenType)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.Blockchain != null)
                {
                    hashCode = (hashCode * 59) + this.Blockchain.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.FromAddress != null)
                {
                    hashCode = (hashCode * 59) + this.FromAddress.GetHashCode();
                }
                if (this.ToAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ToAddress.GetHashCode();
                }
                if (this.SpentFeesAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SpentFeesAmount.GetHashCode();
                }
                if (this.SpentFeesUnit != null)
                {
                    hashCode = (hashCode * 59) + this.SpentFeesUnit.GetHashCode();
                }
                if (this.TriggerTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerTransactionId.GetHashCode();
                }
                if (this.ForwardingTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.ForwardingTransactionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
