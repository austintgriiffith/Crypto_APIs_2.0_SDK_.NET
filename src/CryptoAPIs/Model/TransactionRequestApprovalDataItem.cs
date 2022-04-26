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
    [DataContract(Name = "TransactionRequestApproval_data_item")]
    public partial class TransactionRequestApprovalDataItem : IEquatable<TransactionRequestApprovalDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRequestApprovalDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionRequestApprovalDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRequestApprovalDataItem" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. (required).</param>
        /// <param name="requiredApprovals">The required number of approvals needed to approve the transaction. (required).</param>
        /// <param name="requiredRejections">The required number of rejections needed to reject the transaction. (required).</param>
        /// <param name="currentApprovals">The current number of approvals given for the transaction. (required).</param>
        /// <param name="currentRejections">The current number of rejections given for the transaction. (required).</param>
        public TransactionRequestApprovalDataItem(string blockchain = default(string), string network = default(string), int requiredApprovals = default(int), int requiredRejections = default(int), int currentApprovals = default(int), int currentRejections = default(int))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new ArgumentNullException("blockchain is a required property for TransactionRequestApprovalDataItem and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for TransactionRequestApprovalDataItem and cannot be null");
            }
            this.Network = network;
            this.RequiredApprovals = requiredApprovals;
            this.RequiredRejections = requiredRejections;
            this.CurrentApprovals = currentApprovals;
            this.CurrentRejections = currentRejections;
        }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// The required number of approvals needed to approve the transaction.
        /// </summary>
        /// <value>The required number of approvals needed to approve the transaction.</value>
        [DataMember(Name = "requiredApprovals", IsRequired = true, EmitDefaultValue = false)]
        public int RequiredApprovals { get; set; }

        /// <summary>
        /// The required number of rejections needed to reject the transaction.
        /// </summary>
        /// <value>The required number of rejections needed to reject the transaction.</value>
        [DataMember(Name = "requiredRejections", IsRequired = true, EmitDefaultValue = false)]
        public int RequiredRejections { get; set; }

        /// <summary>
        /// The current number of approvals given for the transaction.
        /// </summary>
        /// <value>The current number of approvals given for the transaction.</value>
        [DataMember(Name = "currentApprovals", IsRequired = true, EmitDefaultValue = false)]
        public int CurrentApprovals { get; set; }

        /// <summary>
        /// The current number of rejections given for the transaction.
        /// </summary>
        /// <value>The current number of rejections given for the transaction.</value>
        [DataMember(Name = "currentRejections", IsRequired = true, EmitDefaultValue = false)]
        public int CurrentRejections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRequestApprovalDataItem {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  RequiredApprovals: ").Append(RequiredApprovals).Append("\n");
            sb.Append("  RequiredRejections: ").Append(RequiredRejections).Append("\n");
            sb.Append("  CurrentApprovals: ").Append(CurrentApprovals).Append("\n");
            sb.Append("  CurrentRejections: ").Append(CurrentRejections).Append("\n");
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
            return this.Equals(input as TransactionRequestApprovalDataItem);
        }

        /// <summary>
        /// Returns true if TransactionRequestApprovalDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRequestApprovalDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRequestApprovalDataItem input)
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
                    this.RequiredApprovals == input.RequiredApprovals ||
                    this.RequiredApprovals.Equals(input.RequiredApprovals)
                ) && 
                (
                    this.RequiredRejections == input.RequiredRejections ||
                    this.RequiredRejections.Equals(input.RequiredRejections)
                ) && 
                (
                    this.CurrentApprovals == input.CurrentApprovals ||
                    this.CurrentApprovals.Equals(input.CurrentApprovals)
                ) && 
                (
                    this.CurrentRejections == input.CurrentRejections ||
                    this.CurrentRejections.Equals(input.CurrentRejections)
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
                hashCode = (hashCode * 59) + this.RequiredApprovals.GetHashCode();
                hashCode = (hashCode * 59) + this.RequiredRejections.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentApprovals.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentRejections.GetHashCode();
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
