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
using System.Reflection;

namespace CryptoAPIs.Model
{
    /// <summary>
    /// GenerateDepositAddressE403
    /// </summary>
    [JsonConverter(typeof(GenerateDepositAddressE403JsonConverter))]
    [DataContract(Name = "GenerateDepositAddressE403")]
    public partial class GenerateDepositAddressE403 : AbstractOpenAPISchema, IEquatable<GenerateDepositAddressE403>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDepositAddressE403" /> class
        /// with the <see cref="BannedIpAddress" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BannedIpAddress.</param>
        public GenerateDepositAddressE403(BannedIpAddress actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDepositAddressE403" /> class
        /// with the <see cref="EndpointNotAllowedForPlan" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointNotAllowedForPlan.</param>
        public GenerateDepositAddressE403(EndpointNotAllowedForPlan actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDepositAddressE403" /> class
        /// with the <see cref="EndpointNotAllowedForApiKey" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointNotAllowedForApiKey.</param>
        public GenerateDepositAddressE403(EndpointNotAllowedForApiKey actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDepositAddressE403" /> class
        /// with the <see cref="FeatureMainnetsNotAllowedForPlan" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FeatureMainnetsNotAllowedForPlan.</param>
        public GenerateDepositAddressE403(FeatureMainnetsNotAllowedForPlan actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDepositAddressE403" /> class
        /// with the <see cref="WalletAsAServiceDepositAddressesLimitReached" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WalletAsAServiceDepositAddressesLimitReached.</param>
        public GenerateDepositAddressE403(WalletAsAServiceDepositAddressesLimitReached actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(BannedIpAddress))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointNotAllowedForApiKey))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointNotAllowedForPlan))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(FeatureMainnetsNotAllowedForPlan))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WalletAsAServiceDepositAddressesLimitReached))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: BannedIpAddress, EndpointNotAllowedForApiKey, EndpointNotAllowedForPlan, FeatureMainnetsNotAllowedForPlan, WalletAsAServiceDepositAddressesLimitReached");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `BannedIpAddress`. If the actual instance is not `BannedIpAddress`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BannedIpAddress</returns>
        public BannedIpAddress GetBannedIpAddress()
        {
            return (BannedIpAddress)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointNotAllowedForPlan`. If the actual instance is not `EndpointNotAllowedForPlan`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointNotAllowedForPlan</returns>
        public EndpointNotAllowedForPlan GetEndpointNotAllowedForPlan()
        {
            return (EndpointNotAllowedForPlan)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointNotAllowedForApiKey`. If the actual instance is not `EndpointNotAllowedForApiKey`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointNotAllowedForApiKey</returns>
        public EndpointNotAllowedForApiKey GetEndpointNotAllowedForApiKey()
        {
            return (EndpointNotAllowedForApiKey)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `FeatureMainnetsNotAllowedForPlan`. If the actual instance is not `FeatureMainnetsNotAllowedForPlan`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of FeatureMainnetsNotAllowedForPlan</returns>
        public FeatureMainnetsNotAllowedForPlan GetFeatureMainnetsNotAllowedForPlan()
        {
            return (FeatureMainnetsNotAllowedForPlan)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `WalletAsAServiceDepositAddressesLimitReached`. If the actual instance is not `WalletAsAServiceDepositAddressesLimitReached`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of WalletAsAServiceDepositAddressesLimitReached</returns>
        public WalletAsAServiceDepositAddressesLimitReached GetWalletAsAServiceDepositAddressesLimitReached()
        {
            return (WalletAsAServiceDepositAddressesLimitReached)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateDepositAddressE403 {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, GenerateDepositAddressE403.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GenerateDepositAddressE403
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GenerateDepositAddressE403</returns>
        public static GenerateDepositAddressE403 FromJson(string jsonString)
        {
            GenerateDepositAddressE403 newGenerateDepositAddressE403 = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGenerateDepositAddressE403;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(BannedIpAddress).GetProperty("AdditionalProperties") == null)
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<BannedIpAddress>(jsonString, GenerateDepositAddressE403.SerializerSettings));
                }
                else
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<BannedIpAddress>(jsonString, GenerateDepositAddressE403.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("BannedIpAddress");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BannedIpAddress: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointNotAllowedForApiKey).GetProperty("AdditionalProperties") == null)
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<EndpointNotAllowedForApiKey>(jsonString, GenerateDepositAddressE403.SerializerSettings));
                }
                else
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<EndpointNotAllowedForApiKey>(jsonString, GenerateDepositAddressE403.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointNotAllowedForApiKey");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointNotAllowedForApiKey: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointNotAllowedForPlan).GetProperty("AdditionalProperties") == null)
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<EndpointNotAllowedForPlan>(jsonString, GenerateDepositAddressE403.SerializerSettings));
                }
                else
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<EndpointNotAllowedForPlan>(jsonString, GenerateDepositAddressE403.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointNotAllowedForPlan");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointNotAllowedForPlan: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FeatureMainnetsNotAllowedForPlan).GetProperty("AdditionalProperties") == null)
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<FeatureMainnetsNotAllowedForPlan>(jsonString, GenerateDepositAddressE403.SerializerSettings));
                }
                else
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<FeatureMainnetsNotAllowedForPlan>(jsonString, GenerateDepositAddressE403.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FeatureMainnetsNotAllowedForPlan");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FeatureMainnetsNotAllowedForPlan: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WalletAsAServiceDepositAddressesLimitReached).GetProperty("AdditionalProperties") == null)
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<WalletAsAServiceDepositAddressesLimitReached>(jsonString, GenerateDepositAddressE403.SerializerSettings));
                }
                else
                {
                    newGenerateDepositAddressE403 = new GenerateDepositAddressE403(JsonConvert.DeserializeObject<WalletAsAServiceDepositAddressesLimitReached>(jsonString, GenerateDepositAddressE403.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WalletAsAServiceDepositAddressesLimitReached");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WalletAsAServiceDepositAddressesLimitReached: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newGenerateDepositAddressE403;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GenerateDepositAddressE403);
        }

        /// <summary>
        /// Returns true if GenerateDepositAddressE403 instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateDepositAddressE403 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateDepositAddressE403 input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for GenerateDepositAddressE403
    /// </summary>
    public class GenerateDepositAddressE403JsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GenerateDepositAddressE403).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return GenerateDepositAddressE403.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
