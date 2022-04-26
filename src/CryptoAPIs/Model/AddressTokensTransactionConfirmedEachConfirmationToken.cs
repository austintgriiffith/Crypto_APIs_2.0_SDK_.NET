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
    /// AddressTokensTransactionConfirmedEachConfirmationToken
    /// </summary>
    [JsonConverter(typeof(AddressTokensTransactionConfirmedEachConfirmationTokenJsonConverter))]
    [DataContract(Name = "AddressTokensTransactionConfirmedEachConfirmationToken")]
    public partial class AddressTokensTransactionConfirmedEachConfirmationToken : AbstractOpenAPISchema, IEquatable<AddressTokensTransactionConfirmedEachConfirmationToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedEachConfirmationToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedEachConfirmationErc20" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedEachConfirmationErc20.</param>
        public AddressTokensTransactionConfirmedEachConfirmationToken(AddressTokensTransactionConfirmedEachConfirmationErc20 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedEachConfirmationToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedEachConfirmationErc721" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedEachConfirmationErc721.</param>
        public AddressTokensTransactionConfirmedEachConfirmationToken(AddressTokensTransactionConfirmedEachConfirmationErc721 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedEachConfirmationToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedEachConfirmationOmni" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedEachConfirmationOmni.</param>
        public AddressTokensTransactionConfirmedEachConfirmationToken(AddressTokensTransactionConfirmedEachConfirmationOmni actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedEachConfirmationToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedEachConfirmationBep20" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedEachConfirmationBep20.</param>
        public AddressTokensTransactionConfirmedEachConfirmationToken(AddressTokensTransactionConfirmedEachConfirmationBep20 actualInstance)
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
                if (value.GetType() == typeof(AddressTokensTransactionConfirmedEachConfirmationBep20))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressTokensTransactionConfirmedEachConfirmationErc20))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressTokensTransactionConfirmedEachConfirmationErc721))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressTokensTransactionConfirmedEachConfirmationOmni))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AddressTokensTransactionConfirmedEachConfirmationBep20, AddressTokensTransactionConfirmedEachConfirmationErc20, AddressTokensTransactionConfirmedEachConfirmationErc721, AddressTokensTransactionConfirmedEachConfirmationOmni");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedEachConfirmationErc20`. If the actual instance is not `AddressTokensTransactionConfirmedEachConfirmationErc20`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedEachConfirmationErc20</returns>
        public AddressTokensTransactionConfirmedEachConfirmationErc20 GetAddressTokensTransactionConfirmedEachConfirmationErc20()
        {
            return (AddressTokensTransactionConfirmedEachConfirmationErc20)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedEachConfirmationErc721`. If the actual instance is not `AddressTokensTransactionConfirmedEachConfirmationErc721`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedEachConfirmationErc721</returns>
        public AddressTokensTransactionConfirmedEachConfirmationErc721 GetAddressTokensTransactionConfirmedEachConfirmationErc721()
        {
            return (AddressTokensTransactionConfirmedEachConfirmationErc721)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedEachConfirmationOmni`. If the actual instance is not `AddressTokensTransactionConfirmedEachConfirmationOmni`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedEachConfirmationOmni</returns>
        public AddressTokensTransactionConfirmedEachConfirmationOmni GetAddressTokensTransactionConfirmedEachConfirmationOmni()
        {
            return (AddressTokensTransactionConfirmedEachConfirmationOmni)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedEachConfirmationBep20`. If the actual instance is not `AddressTokensTransactionConfirmedEachConfirmationBep20`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedEachConfirmationBep20</returns>
        public AddressTokensTransactionConfirmedEachConfirmationBep20 GetAddressTokensTransactionConfirmedEachConfirmationBep20()
        {
            return (AddressTokensTransactionConfirmedEachConfirmationBep20)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressTokensTransactionConfirmedEachConfirmationToken {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AddressTokensTransactionConfirmedEachConfirmationToken.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AddressTokensTransactionConfirmedEachConfirmationToken
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AddressTokensTransactionConfirmedEachConfirmationToken</returns>
        public static AddressTokensTransactionConfirmedEachConfirmationToken FromJson(string jsonString)
        {
            AddressTokensTransactionConfirmedEachConfirmationToken newAddressTokensTransactionConfirmedEachConfirmationToken = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAddressTokensTransactionConfirmedEachConfirmationToken;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedEachConfirmationBep20).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationBep20>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationBep20>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedEachConfirmationBep20");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedEachConfirmationBep20: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedEachConfirmationErc20).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationErc20>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationErc20>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedEachConfirmationErc20");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedEachConfirmationErc20: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedEachConfirmationErc721).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationErc721>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationErc721>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedEachConfirmationErc721");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedEachConfirmationErc721: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedEachConfirmationOmni).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationOmni>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedEachConfirmationToken = new AddressTokensTransactionConfirmedEachConfirmationToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedEachConfirmationOmni>(jsonString, AddressTokensTransactionConfirmedEachConfirmationToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedEachConfirmationOmni");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedEachConfirmationOmni: {1}", jsonString, exception.ToString()));
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
            return newAddressTokensTransactionConfirmedEachConfirmationToken;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressTokensTransactionConfirmedEachConfirmationToken);
        }

        /// <summary>
        /// Returns true if AddressTokensTransactionConfirmedEachConfirmationToken instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressTokensTransactionConfirmedEachConfirmationToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressTokensTransactionConfirmedEachConfirmationToken input)
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
    /// Custom JSON converter for AddressTokensTransactionConfirmedEachConfirmationToken
    /// </summary>
    public class AddressTokensTransactionConfirmedEachConfirmationTokenJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AddressTokensTransactionConfirmedEachConfirmationToken).GetMethod("ToJson").Invoke(value, null)));
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
                return AddressTokensTransactionConfirmedEachConfirmationToken.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
