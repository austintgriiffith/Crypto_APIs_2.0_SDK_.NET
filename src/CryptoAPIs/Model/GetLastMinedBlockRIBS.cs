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
    /// GetLastMinedBlockRIBS
    /// </summary>
    [JsonConverter(typeof(GetLastMinedBlockRIBSJsonConverter))]
    [DataContract(Name = "GetLastMinedBlockRIBS")]
    public partial class GetLastMinedBlockRIBS : AbstractOpenAPISchema, IEquatable<GetLastMinedBlockRIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSB.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSE" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSE.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSE actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSEC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSEC.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSEC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSBC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSBC.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSBC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSL" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSL.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSL actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSD" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSD.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSD actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSD2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSD2.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSD2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSBSC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSBSC.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSBSC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLastMinedBlockRIBS" /> class
        /// with the <see cref="GetLastMinedBlockRIBSZ" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetLastMinedBlockRIBSZ.</param>
        public GetLastMinedBlockRIBS(GetLastMinedBlockRIBSZ actualInstance)
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
                if (value.GetType() == typeof(GetLastMinedBlockRIBSB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSBC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSBSC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSD))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSD2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSE))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSEC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSL))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetLastMinedBlockRIBSZ))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GetLastMinedBlockRIBSB, GetLastMinedBlockRIBSBC, GetLastMinedBlockRIBSBSC, GetLastMinedBlockRIBSD, GetLastMinedBlockRIBSD2, GetLastMinedBlockRIBSE, GetLastMinedBlockRIBSEC, GetLastMinedBlockRIBSL, GetLastMinedBlockRIBSZ");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSB`. If the actual instance is not `GetLastMinedBlockRIBSB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSB</returns>
        public GetLastMinedBlockRIBSB GetGetLastMinedBlockRIBSB()
        {
            return (GetLastMinedBlockRIBSB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSE`. If the actual instance is not `GetLastMinedBlockRIBSE`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSE</returns>
        public GetLastMinedBlockRIBSE GetGetLastMinedBlockRIBSE()
        {
            return (GetLastMinedBlockRIBSE)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSEC`. If the actual instance is not `GetLastMinedBlockRIBSEC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSEC</returns>
        public GetLastMinedBlockRIBSEC GetGetLastMinedBlockRIBSEC()
        {
            return (GetLastMinedBlockRIBSEC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSBC`. If the actual instance is not `GetLastMinedBlockRIBSBC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSBC</returns>
        public GetLastMinedBlockRIBSBC GetGetLastMinedBlockRIBSBC()
        {
            return (GetLastMinedBlockRIBSBC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSL`. If the actual instance is not `GetLastMinedBlockRIBSL`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSL</returns>
        public GetLastMinedBlockRIBSL GetGetLastMinedBlockRIBSL()
        {
            return (GetLastMinedBlockRIBSL)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSD`. If the actual instance is not `GetLastMinedBlockRIBSD`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSD</returns>
        public GetLastMinedBlockRIBSD GetGetLastMinedBlockRIBSD()
        {
            return (GetLastMinedBlockRIBSD)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSD2`. If the actual instance is not `GetLastMinedBlockRIBSD2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSD2</returns>
        public GetLastMinedBlockRIBSD2 GetGetLastMinedBlockRIBSD2()
        {
            return (GetLastMinedBlockRIBSD2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSBSC`. If the actual instance is not `GetLastMinedBlockRIBSBSC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSBSC</returns>
        public GetLastMinedBlockRIBSBSC GetGetLastMinedBlockRIBSBSC()
        {
            return (GetLastMinedBlockRIBSBSC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetLastMinedBlockRIBSZ`. If the actual instance is not `GetLastMinedBlockRIBSZ`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetLastMinedBlockRIBSZ</returns>
        public GetLastMinedBlockRIBSZ GetGetLastMinedBlockRIBSZ()
        {
            return (GetLastMinedBlockRIBSZ)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetLastMinedBlockRIBS {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GetLastMinedBlockRIBS.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetLastMinedBlockRIBS
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetLastMinedBlockRIBS</returns>
        public static GetLastMinedBlockRIBS FromJson(string jsonString)
        {
            GetLastMinedBlockRIBS newGetLastMinedBlockRIBS = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetLastMinedBlockRIBS;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSB).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSB>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSB>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSB: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSBC).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSBC>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSBC>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSBC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSBC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSBSC).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSBSC>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSBSC>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSBSC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSBSC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSD).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSD>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSD>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSD");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSD: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSD2).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSD2>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSD2>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSD2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSD2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSE).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSE>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSE>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSE");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSE: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSEC).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSEC>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSEC>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSEC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSEC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSL).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSL>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSL>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSL");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSL: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetLastMinedBlockRIBSZ).GetProperty("AdditionalProperties") == null)
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSZ>(jsonString, GetLastMinedBlockRIBS.SerializerSettings));
                }
                else
                {
                    newGetLastMinedBlockRIBS = new GetLastMinedBlockRIBS(JsonConvert.DeserializeObject<GetLastMinedBlockRIBSZ>(jsonString, GetLastMinedBlockRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetLastMinedBlockRIBSZ");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetLastMinedBlockRIBSZ: {1}", jsonString, exception.ToString()));
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
            return newGetLastMinedBlockRIBS;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetLastMinedBlockRIBS);
        }

        /// <summary>
        /// Returns true if GetLastMinedBlockRIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of GetLastMinedBlockRIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetLastMinedBlockRIBS input)
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
    /// Custom JSON converter for GetLastMinedBlockRIBS
    /// </summary>
    public class GetLastMinedBlockRIBSJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetLastMinedBlockRIBS).GetMethod("ToJson").Invoke(value, null)));
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
                return GetLastMinedBlockRIBS.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
