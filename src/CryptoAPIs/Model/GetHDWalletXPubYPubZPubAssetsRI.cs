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
    /// GetHDWalletXPubYPubZPubAssetsRI
    /// </summary>
    [DataContract(Name = "GetHDWalletXPubYPubZPubAssetsRI")]
    public partial class GetHDWalletXPubYPubZPubAssetsRI : IEquatable<GetHDWalletXPubYPubZPubAssetsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHDWalletXPubYPubZPubAssetsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetHDWalletXPubYPubZPubAssetsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHDWalletXPubYPubZPubAssetsRI" /> class.
        /// </summary>
        /// <param name="fungibleTokens">Represents fungible tokens&#39;es detailed information.</param>
        /// <param name="nonFungibleTokens">Represents non-fungible tokens&#39;es detailed information..</param>
        /// <param name="confirmedBalance">confirmedBalance (required).</param>
        public GetHDWalletXPubYPubZPubAssetsRI(List<GetHDWalletXPubYPubZPubAssetsRIFungibleTokens> fungibleTokens = default(List<GetHDWalletXPubYPubZPubAssetsRIFungibleTokens>), List<GetHDWalletXPubYPubZPubAssetsRINonFungibleTokens> nonFungibleTokens = default(List<GetHDWalletXPubYPubZPubAssetsRINonFungibleTokens>), GetHDWalletXPubYPubZPubAssetsRIConfirmedBalance confirmedBalance = default(GetHDWalletXPubYPubZPubAssetsRIConfirmedBalance))
        {
            // to ensure "confirmedBalance" is required (not null)
            if (confirmedBalance == null)
            {
                throw new ArgumentNullException("confirmedBalance is a required property for GetHDWalletXPubYPubZPubAssetsRI and cannot be null");
            }
            this.ConfirmedBalance = confirmedBalance;
            this.FungibleTokens = fungibleTokens;
            this.NonFungibleTokens = nonFungibleTokens;
        }

        /// <summary>
        /// Represents fungible tokens&#39;es detailed information
        /// </summary>
        /// <value>Represents fungible tokens&#39;es detailed information</value>
        [DataMember(Name = "fungibleTokens", EmitDefaultValue = false)]
        public List<GetHDWalletXPubYPubZPubAssetsRIFungibleTokens> FungibleTokens { get; set; }

        /// <summary>
        /// Represents non-fungible tokens&#39;es detailed information.
        /// </summary>
        /// <value>Represents non-fungible tokens&#39;es detailed information.</value>
        [DataMember(Name = "nonFungibleTokens", EmitDefaultValue = false)]
        public List<GetHDWalletXPubYPubZPubAssetsRINonFungibleTokens> NonFungibleTokens { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedBalance
        /// </summary>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public GetHDWalletXPubYPubZPubAssetsRIConfirmedBalance ConfirmedBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetHDWalletXPubYPubZPubAssetsRI {\n");
            sb.Append("  FungibleTokens: ").Append(FungibleTokens).Append("\n");
            sb.Append("  NonFungibleTokens: ").Append(NonFungibleTokens).Append("\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
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
            return this.Equals(input as GetHDWalletXPubYPubZPubAssetsRI);
        }

        /// <summary>
        /// Returns true if GetHDWalletXPubYPubZPubAssetsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetHDWalletXPubYPubZPubAssetsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetHDWalletXPubYPubZPubAssetsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FungibleTokens == input.FungibleTokens ||
                    this.FungibleTokens != null &&
                    input.FungibleTokens != null &&
                    this.FungibleTokens.SequenceEqual(input.FungibleTokens)
                ) && 
                (
                    this.NonFungibleTokens == input.NonFungibleTokens ||
                    this.NonFungibleTokens != null &&
                    input.NonFungibleTokens != null &&
                    this.NonFungibleTokens.SequenceEqual(input.NonFungibleTokens)
                ) && 
                (
                    this.ConfirmedBalance == input.ConfirmedBalance ||
                    (this.ConfirmedBalance != null &&
                    this.ConfirmedBalance.Equals(input.ConfirmedBalance))
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
                if (this.FungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.FungibleTokens.GetHashCode();
                }
                if (this.NonFungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.NonFungibleTokens.GetHashCode();
                }
                if (this.ConfirmedBalance != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmedBalance.GetHashCode();
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
