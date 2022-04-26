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
    /// feature_mainnets_not_allowed_for_plan
    /// </summary>
    [DataContract(Name = "FeatureMainnetsNotAllowedForPlan")]
    public partial class FeatureMainnetsNotAllowedForPlan : IEquatable<FeatureMainnetsNotAllowedForPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureMainnetsNotAllowedForPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeatureMainnetsNotAllowedForPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureMainnetsNotAllowedForPlan" /> class.
        /// </summary>
        /// <param name="code">Specifies an error code, e.g. error 404. (required).</param>
        /// <param name="message">Specifies the message of the error, i.e. why the error was returned, e.g. error 404 stands for “not found”. (required).</param>
        /// <param name="details">details.</param>
        public FeatureMainnetsNotAllowedForPlan(string code = default(string), string message = default(string), List<BannedIpAddressDetails> details = default(List<BannedIpAddressDetails>))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for FeatureMainnetsNotAllowedForPlan and cannot be null");
            }
            this.Code = code;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for FeatureMainnetsNotAllowedForPlan and cannot be null");
            }
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Specifies an error code, e.g. error 404.
        /// </summary>
        /// <value>Specifies an error code, e.g. error 404.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Specifies the message of the error, i.e. why the error was returned, e.g. error 404 stands for “not found”.
        /// </summary>
        /// <value>Specifies the message of the error, i.e. why the error was returned, e.g. error 404 stands for “not found”.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<BannedIpAddressDetails> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeatureMainnetsNotAllowedForPlan {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as FeatureMainnetsNotAllowedForPlan);
        }

        /// <summary>
        /// Returns true if FeatureMainnetsNotAllowedForPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureMainnetsNotAllowedForPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureMainnetsNotAllowedForPlan input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
