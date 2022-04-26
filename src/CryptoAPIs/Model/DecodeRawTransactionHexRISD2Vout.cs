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
    /// DecodeRawTransactionHexRISD2Vout
    /// </summary>
    [DataContract(Name = "DecodeRawTransactionHexRISD2_vout")]
    public partial class DecodeRawTransactionHexRISD2Vout : IEquatable<DecodeRawTransactionHexRISD2Vout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISD2Vout" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecodeRawTransactionHexRISD2Vout() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISD2Vout" /> class.
        /// </summary>
        /// <param name="scriptPubKey">scriptPubKey (required).</param>
        /// <param name="value">Represents the sent/received amount..</param>
        public DecodeRawTransactionHexRISD2Vout(DecodeRawTransactionHexRISD2ScriptPubKey scriptPubKey = default(DecodeRawTransactionHexRISD2ScriptPubKey), string value = default(string))
        {
            // to ensure "scriptPubKey" is required (not null)
            if (scriptPubKey == null)
            {
                throw new ArgumentNullException("scriptPubKey is a required property for DecodeRawTransactionHexRISD2Vout and cannot be null");
            }
            this.ScriptPubKey = scriptPubKey;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets ScriptPubKey
        /// </summary>
        [DataMember(Name = "scriptPubKey", IsRequired = true, EmitDefaultValue = false)]
        public DecodeRawTransactionHexRISD2ScriptPubKey ScriptPubKey { get; set; }

        /// <summary>
        /// Represents the sent/received amount.
        /// </summary>
        /// <value>Represents the sent/received amount.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DecodeRawTransactionHexRISD2Vout {\n");
            sb.Append("  ScriptPubKey: ").Append(ScriptPubKey).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DecodeRawTransactionHexRISD2Vout);
        }

        /// <summary>
        /// Returns true if DecodeRawTransactionHexRISD2Vout instances are equal
        /// </summary>
        /// <param name="input">Instance of DecodeRawTransactionHexRISD2Vout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecodeRawTransactionHexRISD2Vout input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ScriptPubKey == input.ScriptPubKey ||
                    (this.ScriptPubKey != null &&
                    this.ScriptPubKey.Equals(input.ScriptPubKey))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.ScriptPubKey != null)
                {
                    hashCode = (hashCode * 59) + this.ScriptPubKey.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
