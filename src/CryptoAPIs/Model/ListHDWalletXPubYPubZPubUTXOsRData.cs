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
    /// ListHDWalletXPubYPubZPubUTXOsRData
    /// </summary>
    [DataContract(Name = "ListHDWalletXPubYPubZPubUTXOsR_data")]
    public partial class ListHDWalletXPubYPubZPubUTXOsRData : IEquatable<ListHDWalletXPubYPubZPubUTXOsRData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListHDWalletXPubYPubZPubUTXOsRData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListHDWalletXPubYPubZPubUTXOsRData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListHDWalletXPubYPubZPubUTXOsRData" /> class.
        /// </summary>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (required).</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (required).</param>
        /// <param name="total">Defines the total number of items returned in the response. (required).</param>
        /// <param name="items">items (required).</param>
        public ListHDWalletXPubYPubZPubUTXOsRData(int limit = default(int), int offset = default(int), int total = default(int), List<ListHDWalletXPubYPubZPubUTXOsRI> items = default(List<ListHDWalletXPubYPubZPubUTXOsRI>))
        {
            this.Limit = limit;
            this.Offset = offset;
            this.Total = total;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for ListHDWalletXPubYPubZPubUTXOsRData and cannot be null");
            }
            this.Items = items;
        }

        /// <summary>
        /// Defines how many items should be returned in the response per page basis.
        /// </summary>
        /// <value>Defines how many items should be returned in the response per page basis.</value>
        [DataMember(Name = "limit", IsRequired = true, EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// The starting index of the response items, i.e. where the response should start listing the returned items.
        /// </summary>
        /// <value>The starting index of the response items, i.e. where the response should start listing the returned items.</value>
        [DataMember(Name = "offset", IsRequired = true, EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// Defines the total number of items returned in the response.
        /// </summary>
        /// <value>Defines the total number of items returned in the response.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = false)]
        public List<ListHDWalletXPubYPubZPubUTXOsRI> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListHDWalletXPubYPubZPubUTXOsRData {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ListHDWalletXPubYPubZPubUTXOsRData);
        }

        /// <summary>
        /// Returns true if ListHDWalletXPubYPubZPubUTXOsRData instances are equal
        /// </summary>
        /// <param name="input">Instance of ListHDWalletXPubYPubZPubUTXOsRData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListHDWalletXPubYPubZPubUTXOsRData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Offset == input.Offset ||
                    this.Offset.Equals(input.Offset)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.Offset.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
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
