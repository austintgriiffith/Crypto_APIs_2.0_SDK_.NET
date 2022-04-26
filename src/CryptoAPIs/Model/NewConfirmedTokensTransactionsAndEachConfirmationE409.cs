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
    /// NewConfirmedTokensTransactionsAndEachConfirmationE409
    /// </summary>
    [JsonConverter(typeof(NewConfirmedTokensTransactionsAndEachConfirmationE409JsonConverter))]
    [DataContract(Name = "NewConfirmedTokensTransactionsAndEachConfirmationE409")]
    public partial class NewConfirmedTokensTransactionsAndEachConfirmationE409 : AbstractOpenAPISchema, IEquatable<NewConfirmedTokensTransactionsAndEachConfirmationE409>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedTokensTransactionsAndEachConfirmationE409" /> class
        /// with the <see cref="InvalidData" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InvalidData.</param>
        public NewConfirmedTokensTransactionsAndEachConfirmationE409(InvalidData actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedTokensTransactionsAndEachConfirmationE409" /> class
        /// with the <see cref="AlreadyExists" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AlreadyExists.</param>
        public NewConfirmedTokensTransactionsAndEachConfirmationE409(AlreadyExists actualInstance)
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
                if (value.GetType() == typeof(AlreadyExists))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(InvalidData))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AlreadyExists, InvalidData");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `InvalidData`. If the actual instance is not `InvalidData`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InvalidData</returns>
        public InvalidData GetInvalidData()
        {
            return (InvalidData)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AlreadyExists`. If the actual instance is not `AlreadyExists`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AlreadyExists</returns>
        public AlreadyExists GetAlreadyExists()
        {
            return (AlreadyExists)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewConfirmedTokensTransactionsAndEachConfirmationE409 {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NewConfirmedTokensTransactionsAndEachConfirmationE409.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NewConfirmedTokensTransactionsAndEachConfirmationE409
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NewConfirmedTokensTransactionsAndEachConfirmationE409</returns>
        public static NewConfirmedTokensTransactionsAndEachConfirmationE409 FromJson(string jsonString)
        {
            NewConfirmedTokensTransactionsAndEachConfirmationE409 newNewConfirmedTokensTransactionsAndEachConfirmationE409 = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNewConfirmedTokensTransactionsAndEachConfirmationE409;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AlreadyExists).GetProperty("AdditionalProperties") == null)
                {
                    newNewConfirmedTokensTransactionsAndEachConfirmationE409 = new NewConfirmedTokensTransactionsAndEachConfirmationE409(JsonConvert.DeserializeObject<AlreadyExists>(jsonString, NewConfirmedTokensTransactionsAndEachConfirmationE409.SerializerSettings));
                }
                else
                {
                    newNewConfirmedTokensTransactionsAndEachConfirmationE409 = new NewConfirmedTokensTransactionsAndEachConfirmationE409(JsonConvert.DeserializeObject<AlreadyExists>(jsonString, NewConfirmedTokensTransactionsAndEachConfirmationE409.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AlreadyExists");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AlreadyExists: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InvalidData).GetProperty("AdditionalProperties") == null)
                {
                    newNewConfirmedTokensTransactionsAndEachConfirmationE409 = new NewConfirmedTokensTransactionsAndEachConfirmationE409(JsonConvert.DeserializeObject<InvalidData>(jsonString, NewConfirmedTokensTransactionsAndEachConfirmationE409.SerializerSettings));
                }
                else
                {
                    newNewConfirmedTokensTransactionsAndEachConfirmationE409 = new NewConfirmedTokensTransactionsAndEachConfirmationE409(JsonConvert.DeserializeObject<InvalidData>(jsonString, NewConfirmedTokensTransactionsAndEachConfirmationE409.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InvalidData");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InvalidData: {1}", jsonString, exception.ToString()));
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
            return newNewConfirmedTokensTransactionsAndEachConfirmationE409;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewConfirmedTokensTransactionsAndEachConfirmationE409);
        }

        /// <summary>
        /// Returns true if NewConfirmedTokensTransactionsAndEachConfirmationE409 instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedTokensTransactionsAndEachConfirmationE409 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedTokensTransactionsAndEachConfirmationE409 input)
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
    /// Custom JSON converter for NewConfirmedTokensTransactionsAndEachConfirmationE409
    /// </summary>
    public class NewConfirmedTokensTransactionsAndEachConfirmationE409JsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NewConfirmedTokensTransactionsAndEachConfirmationE409).GetMethod("ToJson").Invoke(value, null)));
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
                return NewConfirmedTokensTransactionsAndEachConfirmationE409.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
