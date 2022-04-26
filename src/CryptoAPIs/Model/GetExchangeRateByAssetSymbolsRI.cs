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
    /// GetExchangeRateByAssetSymbolsRI
    /// </summary>
    [DataContract(Name = "GetExchangeRateByAssetSymbolsRI")]
    public partial class GetExchangeRateByAssetSymbolsRI : IEquatable<GetExchangeRateByAssetSymbolsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExchangeRateByAssetSymbolsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExchangeRateByAssetSymbolsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExchangeRateByAssetSymbolsRI" /> class.
        /// </summary>
        /// <param name="calculationTimestamp">Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp. (required).</param>
        /// <param name="fromAssetId">Defines the base asset Reference ID to get a rate for. (required).</param>
        /// <param name="fromAssetSymbol">Defines the base asset symbol to get a rate for. (required).</param>
        /// <param name="rate">Defines the exchange rate between assets calculated by weighted average of the last trades in every exchange for the last 24 hours by giving more weight to exchanges with higher volume. (required).</param>
        /// <param name="toAssetId">Defines the relation asset Reference ID in which the base asset rate will be displayed. (required).</param>
        /// <param name="toAssetSymbol">Defines the relation asset symbol in which the base asset rate will be displayed. (required).</param>
        public GetExchangeRateByAssetSymbolsRI(int calculationTimestamp = default(int), string fromAssetId = default(string), string fromAssetSymbol = default(string), string rate = default(string), string toAssetId = default(string), string toAssetSymbol = default(string))
        {
            this.CalculationTimestamp = calculationTimestamp;
            // to ensure "fromAssetId" is required (not null)
            if (fromAssetId == null)
            {
                throw new ArgumentNullException("fromAssetId is a required property for GetExchangeRateByAssetSymbolsRI and cannot be null");
            }
            this.FromAssetId = fromAssetId;
            // to ensure "fromAssetSymbol" is required (not null)
            if (fromAssetSymbol == null)
            {
                throw new ArgumentNullException("fromAssetSymbol is a required property for GetExchangeRateByAssetSymbolsRI and cannot be null");
            }
            this.FromAssetSymbol = fromAssetSymbol;
            // to ensure "rate" is required (not null)
            if (rate == null)
            {
                throw new ArgumentNullException("rate is a required property for GetExchangeRateByAssetSymbolsRI and cannot be null");
            }
            this.Rate = rate;
            // to ensure "toAssetId" is required (not null)
            if (toAssetId == null)
            {
                throw new ArgumentNullException("toAssetId is a required property for GetExchangeRateByAssetSymbolsRI and cannot be null");
            }
            this.ToAssetId = toAssetId;
            // to ensure "toAssetSymbol" is required (not null)
            if (toAssetSymbol == null)
            {
                throw new ArgumentNullException("toAssetSymbol is a required property for GetExchangeRateByAssetSymbolsRI and cannot be null");
            }
            this.ToAssetSymbol = toAssetSymbol;
        }

        /// <summary>
        /// Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp.
        /// </summary>
        /// <value>Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp.</value>
        [DataMember(Name = "calculationTimestamp", IsRequired = true, EmitDefaultValue = false)]
        public int CalculationTimestamp { get; set; }

        /// <summary>
        /// Defines the base asset Reference ID to get a rate for.
        /// </summary>
        /// <value>Defines the base asset Reference ID to get a rate for.</value>
        [DataMember(Name = "fromAssetId", IsRequired = true, EmitDefaultValue = false)]
        public string FromAssetId { get; set; }

        /// <summary>
        /// Defines the base asset symbol to get a rate for.
        /// </summary>
        /// <value>Defines the base asset symbol to get a rate for.</value>
        [DataMember(Name = "fromAssetSymbol", IsRequired = true, EmitDefaultValue = false)]
        public string FromAssetSymbol { get; set; }

        /// <summary>
        /// Defines the exchange rate between assets calculated by weighted average of the last trades in every exchange for the last 24 hours by giving more weight to exchanges with higher volume.
        /// </summary>
        /// <value>Defines the exchange rate between assets calculated by weighted average of the last trades in every exchange for the last 24 hours by giving more weight to exchanges with higher volume.</value>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = false)]
        public string Rate { get; set; }

        /// <summary>
        /// Defines the relation asset Reference ID in which the base asset rate will be displayed.
        /// </summary>
        /// <value>Defines the relation asset Reference ID in which the base asset rate will be displayed.</value>
        [DataMember(Name = "toAssetId", IsRequired = true, EmitDefaultValue = false)]
        public string ToAssetId { get; set; }

        /// <summary>
        /// Defines the relation asset symbol in which the base asset rate will be displayed.
        /// </summary>
        /// <value>Defines the relation asset symbol in which the base asset rate will be displayed.</value>
        [DataMember(Name = "toAssetSymbol", IsRequired = true, EmitDefaultValue = false)]
        public string ToAssetSymbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetExchangeRateByAssetSymbolsRI {\n");
            sb.Append("  CalculationTimestamp: ").Append(CalculationTimestamp).Append("\n");
            sb.Append("  FromAssetId: ").Append(FromAssetId).Append("\n");
            sb.Append("  FromAssetSymbol: ").Append(FromAssetSymbol).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ToAssetId: ").Append(ToAssetId).Append("\n");
            sb.Append("  ToAssetSymbol: ").Append(ToAssetSymbol).Append("\n");
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
            return this.Equals(input as GetExchangeRateByAssetSymbolsRI);
        }

        /// <summary>
        /// Returns true if GetExchangeRateByAssetSymbolsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExchangeRateByAssetSymbolsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExchangeRateByAssetSymbolsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CalculationTimestamp == input.CalculationTimestamp ||
                    this.CalculationTimestamp.Equals(input.CalculationTimestamp)
                ) && 
                (
                    this.FromAssetId == input.FromAssetId ||
                    (this.FromAssetId != null &&
                    this.FromAssetId.Equals(input.FromAssetId))
                ) && 
                (
                    this.FromAssetSymbol == input.FromAssetSymbol ||
                    (this.FromAssetSymbol != null &&
                    this.FromAssetSymbol.Equals(input.FromAssetSymbol))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.ToAssetId == input.ToAssetId ||
                    (this.ToAssetId != null &&
                    this.ToAssetId.Equals(input.ToAssetId))
                ) && 
                (
                    this.ToAssetSymbol == input.ToAssetSymbol ||
                    (this.ToAssetSymbol != null &&
                    this.ToAssetSymbol.Equals(input.ToAssetSymbol))
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
                hashCode = (hashCode * 59) + this.CalculationTimestamp.GetHashCode();
                if (this.FromAssetId != null)
                {
                    hashCode = (hashCode * 59) + this.FromAssetId.GetHashCode();
                }
                if (this.FromAssetSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.FromAssetSymbol.GetHashCode();
                }
                if (this.Rate != null)
                {
                    hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                }
                if (this.ToAssetId != null)
                {
                    hashCode = (hashCode * 59) + this.ToAssetId.GetHashCode();
                }
                if (this.ToAssetSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.ToAssetSymbol.GetHashCode();
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
