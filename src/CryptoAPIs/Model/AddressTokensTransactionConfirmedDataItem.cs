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
    [DataContract(Name = "AddressTokensTransactionConfirmed_data_item")]
    public partial class AddressTokensTransactionConfirmedDataItem : IEquatable<AddressTokensTransactionConfirmedDataItem>, IValidatableObject
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
            OMNI = 3,

            /// <summary>
            /// Enum BEP20 for value: BEP-20
            /// </summary>
            [EnumMember(Value = "BEP-20")]
            BEP20 = 4

        }


        /// <summary>
        /// Defines the type of token sent with the transaction, e.g. ERC 20.
        /// </summary>
        /// <value>Defines the type of token sent with the transaction, e.g. ERC 20.</value>
        [DataMember(Name = "tokenType", IsRequired = true, EmitDefaultValue = false)]
        public TokenTypeEnum TokenType { get; set; }
        /// <summary>
        /// Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.
        /// </summary>
        /// <value>Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Incoming for value: incoming
            /// </summary>
            [EnumMember(Value = "incoming")]
            Incoming = 1,

            /// <summary>
            /// Enum Outgoing for value: outgoing
            /// </summary>
            [EnumMember(Value = "outgoing")]
            Outgoing = 2

        }


        /// <summary>
        /// Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.
        /// </summary>
        /// <value>Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.</value>
        [DataMember(Name = "direction", IsRequired = true, EmitDefaultValue = false)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressTokensTransactionConfirmedDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedDataItem" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;,  are test networks. (required).</param>
        /// <param name="address">Defines the specific address to which the transaction has been sent. (required).</param>
        /// <param name="minedInBlock">minedInBlock (required).</param>
        /// <param name="transactionId">Defines the unique ID of the specific transaction, i.e. its identification number. (required).</param>
        /// <param name="tokenType">Defines the type of token sent with the transaction, e.g. ERC 20. (required).</param>
        /// <param name="token">token (required).</param>
        /// <param name="direction">Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;. (required).</param>
        public AddressTokensTransactionConfirmedDataItem(string blockchain = default(string), string network = default(string), string address = default(string), AddressTokensTransactionConfirmedDataItemMinedInBlock minedInBlock = default(AddressTokensTransactionConfirmedDataItemMinedInBlock), string transactionId = default(string), TokenTypeEnum tokenType = default(TokenTypeEnum), AddressTokensTransactionConfirmedToken token = default(AddressTokensTransactionConfirmedToken), DirectionEnum direction = default(DirectionEnum))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new ArgumentNullException("blockchain is a required property for AddressTokensTransactionConfirmedDataItem and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for AddressTokensTransactionConfirmedDataItem and cannot be null");
            }
            this.Network = network;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for AddressTokensTransactionConfirmedDataItem and cannot be null");
            }
            this.Address = address;
            // to ensure "minedInBlock" is required (not null)
            if (minedInBlock == null)
            {
                throw new ArgumentNullException("minedInBlock is a required property for AddressTokensTransactionConfirmedDataItem and cannot be null");
            }
            this.MinedInBlock = minedInBlock;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for AddressTokensTransactionConfirmedDataItem and cannot be null");
            }
            this.TransactionId = transactionId;
            this.TokenType = tokenType;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for AddressTokensTransactionConfirmedDataItem and cannot be null");
            }
            this.Token = token;
            this.Direction = direction;
        }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;,  are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;,  are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Defines the specific address to which the transaction has been sent.
        /// </summary>
        /// <value>Defines the specific address to which the transaction has been sent.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets MinedInBlock
        /// </summary>
        [DataMember(Name = "minedInBlock", IsRequired = true, EmitDefaultValue = false)]
        public AddressTokensTransactionConfirmedDataItemMinedInBlock MinedInBlock { get; set; }

        /// <summary>
        /// Defines the unique ID of the specific transaction, i.e. its identification number.
        /// </summary>
        /// <value>Defines the unique ID of the specific transaction, i.e. its identification number.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = false)]
        public AddressTokensTransactionConfirmedToken Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressTokensTransactionConfirmedDataItem {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  MinedInBlock: ").Append(MinedInBlock).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as AddressTokensTransactionConfirmedDataItem);
        }

        /// <summary>
        /// Returns true if AddressTokensTransactionConfirmedDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressTokensTransactionConfirmedDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressTokensTransactionConfirmedDataItem input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.MinedInBlock == input.MinedInBlock ||
                    (this.MinedInBlock != null &&
                    this.MinedInBlock.Equals(input.MinedInBlock))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    this.TokenType.Equals(input.TokenType)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.MinedInBlock != null)
                {
                    hashCode = (hashCode * 59) + this.MinedInBlock.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Direction.GetHashCode();
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
