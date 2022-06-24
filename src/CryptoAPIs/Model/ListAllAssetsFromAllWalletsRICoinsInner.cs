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
    /// ListAllAssetsFromAllWalletsRICoinsInner
    /// </summary>
    [DataContract(Name = "ListAllAssetsFromAllWalletsRI_coins_inner")]
    public partial class ListAllAssetsFromAllWalletsRICoinsInner : IEquatable<ListAllAssetsFromAllWalletsRICoinsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllAssetsFromAllWalletsRICoinsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListAllAssetsFromAllWalletsRICoinsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllAssetsFromAllWalletsRICoinsInner" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="confirmedBalance">Defines the total balance of the address that is confirmed. It doesn&#39;t include unconfirmed transactions. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. (required).</param>
        /// <param name="totalReceived">Defines the total amount of all coins received to the address, based on confirmed transactions. (required).</param>
        /// <param name="totalSpent">Defines the total amount of all spent by this address coins, based on confirmed transactions. (required).</param>
        /// <param name="unit">Represents the unit of the confirmed balance. (required).</param>
        public ListAllAssetsFromAllWalletsRICoinsInner(string blockchain = default(string), string confirmedBalance = default(string), string network = default(string), string totalReceived = default(string), string totalSpent = default(string), string unit = default(string))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new ArgumentNullException("blockchain is a required property for ListAllAssetsFromAllWalletsRICoinsInner and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "confirmedBalance" is required (not null)
            if (confirmedBalance == null)
            {
                throw new ArgumentNullException("confirmedBalance is a required property for ListAllAssetsFromAllWalletsRICoinsInner and cannot be null");
            }
            this.ConfirmedBalance = confirmedBalance;
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for ListAllAssetsFromAllWalletsRICoinsInner and cannot be null");
            }
            this.Network = network;
            // to ensure "totalReceived" is required (not null)
            if (totalReceived == null)
            {
                throw new ArgumentNullException("totalReceived is a required property for ListAllAssetsFromAllWalletsRICoinsInner and cannot be null");
            }
            this.TotalReceived = totalReceived;
            // to ensure "totalSpent" is required (not null)
            if (totalSpent == null)
            {
                throw new ArgumentNullException("totalSpent is a required property for ListAllAssetsFromAllWalletsRICoinsInner and cannot be null");
            }
            this.TotalSpent = totalSpent;
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new ArgumentNullException("unit is a required property for ListAllAssetsFromAllWalletsRICoinsInner and cannot be null");
            }
            this.Unit = unit;
        }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Defines the total balance of the address that is confirmed. It doesn&#39;t include unconfirmed transactions.
        /// </summary>
        /// <value>Defines the total balance of the address that is confirmed. It doesn&#39;t include unconfirmed transactions.</value>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public string ConfirmedBalance { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Defines the total amount of all coins received to the address, based on confirmed transactions.
        /// </summary>
        /// <value>Defines the total amount of all coins received to the address, based on confirmed transactions.</value>
        [DataMember(Name = "totalReceived", IsRequired = true, EmitDefaultValue = false)]
        public string TotalReceived { get; set; }

        /// <summary>
        /// Defines the total amount of all spent by this address coins, based on confirmed transactions.
        /// </summary>
        /// <value>Defines the total amount of all spent by this address coins, based on confirmed transactions.</value>
        [DataMember(Name = "totalSpent", IsRequired = true, EmitDefaultValue = false)]
        public string TotalSpent { get; set; }

        /// <summary>
        /// Represents the unit of the confirmed balance.
        /// </summary>
        /// <value>Represents the unit of the confirmed balance.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListAllAssetsFromAllWalletsRICoinsInner {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  TotalReceived: ").Append(TotalReceived).Append("\n");
            sb.Append("  TotalSpent: ").Append(TotalSpent).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as ListAllAssetsFromAllWalletsRICoinsInner);
        }

        /// <summary>
        /// Returns true if ListAllAssetsFromAllWalletsRICoinsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAllAssetsFromAllWalletsRICoinsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAllAssetsFromAllWalletsRICoinsInner input)
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
                    this.ConfirmedBalance == input.ConfirmedBalance ||
                    (this.ConfirmedBalance != null &&
                    this.ConfirmedBalance.Equals(input.ConfirmedBalance))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.TotalReceived == input.TotalReceived ||
                    (this.TotalReceived != null &&
                    this.TotalReceived.Equals(input.TotalReceived))
                ) && 
                (
                    this.TotalSpent == input.TotalSpent ||
                    (this.TotalSpent != null &&
                    this.TotalSpent.Equals(input.TotalSpent))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.ConfirmedBalance != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmedBalance.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.TotalReceived != null)
                {
                    hashCode = (hashCode * 59) + this.TotalReceived.GetHashCode();
                }
                if (this.TotalSpent != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSpent.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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