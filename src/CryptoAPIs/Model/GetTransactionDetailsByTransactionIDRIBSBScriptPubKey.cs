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
    /// Represents the script public key.
    /// </summary>
    [DataContract(Name = "GetTransactionDetailsByTransactionIDRIBSB_scriptPubKey")]
    public partial class GetTransactionDetailsByTransactionIDRIBSBScriptPubKey : IEquatable<GetTransactionDetailsByTransactionIDRIBSBScriptPubKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBSBScriptPubKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionDetailsByTransactionIDRIBSBScriptPubKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBSBScriptPubKey" /> class.
        /// </summary>
        /// <param name="addresses">addresses (required).</param>
        /// <param name="asm">Represents the assembly of the script public key of the address. (required).</param>
        /// <param name="hex">Represents the hex of the script public key of the address. (required).</param>
        /// <param name="reqSigs">Represents the required signatures. (required).</param>
        /// <param name="type">Represents the script type. (required).</param>
        public GetTransactionDetailsByTransactionIDRIBSBScriptPubKey(List<string> addresses = default(List<string>), string asm = default(string), string hex = default(string), int reqSigs = default(int), string type = default(string))
        {
            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new ArgumentNullException("addresses is a required property for GetTransactionDetailsByTransactionIDRIBSBScriptPubKey and cannot be null");
            }
            this.Addresses = addresses;
            // to ensure "asm" is required (not null)
            if (asm == null)
            {
                throw new ArgumentNullException("asm is a required property for GetTransactionDetailsByTransactionIDRIBSBScriptPubKey and cannot be null");
            }
            this.Asm = asm;
            // to ensure "hex" is required (not null)
            if (hex == null)
            {
                throw new ArgumentNullException("hex is a required property for GetTransactionDetailsByTransactionIDRIBSBScriptPubKey and cannot be null");
            }
            this.Hex = hex;
            this.ReqSigs = reqSigs;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for GetTransactionDetailsByTransactionIDRIBSBScriptPubKey and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// Represents the assembly of the script public key of the address.
        /// </summary>
        /// <value>Represents the assembly of the script public key of the address.</value>
        [DataMember(Name = "asm", IsRequired = true, EmitDefaultValue = false)]
        public string Asm { get; set; }

        /// <summary>
        /// Represents the hex of the script public key of the address.
        /// </summary>
        /// <value>Represents the hex of the script public key of the address.</value>
        [DataMember(Name = "hex", IsRequired = true, EmitDefaultValue = false)]
        public string Hex { get; set; }

        /// <summary>
        /// Represents the required signatures.
        /// </summary>
        /// <value>Represents the required signatures.</value>
        [DataMember(Name = "reqSigs", IsRequired = true, EmitDefaultValue = false)]
        public int ReqSigs { get; set; }

        /// <summary>
        /// Represents the script type.
        /// </summary>
        /// <value>Represents the script type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionDetailsByTransactionIDRIBSBScriptPubKey {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Asm: ").Append(Asm).Append("\n");
            sb.Append("  Hex: ").Append(Hex).Append("\n");
            sb.Append("  ReqSigs: ").Append(ReqSigs).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetTransactionDetailsByTransactionIDRIBSBScriptPubKey);
        }

        /// <summary>
        /// Returns true if GetTransactionDetailsByTransactionIDRIBSBScriptPubKey instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionDetailsByTransactionIDRIBSBScriptPubKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionDetailsByTransactionIDRIBSBScriptPubKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Asm == input.Asm ||
                    (this.Asm != null &&
                    this.Asm.Equals(input.Asm))
                ) && 
                (
                    this.Hex == input.Hex ||
                    (this.Hex != null &&
                    this.Hex.Equals(input.Hex))
                ) && 
                (
                    this.ReqSigs == input.ReqSigs ||
                    this.ReqSigs.Equals(input.ReqSigs)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.Asm != null)
                {
                    hashCode = (hashCode * 59) + this.Asm.GetHashCode();
                }
                if (this.Hex != null)
                {
                    hashCode = (hashCode * 59) + this.Hex.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReqSigs.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
