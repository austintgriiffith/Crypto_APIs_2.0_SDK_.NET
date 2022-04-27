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
    /// GetBlockDetailsByBlockHashFromCallbackRIBS
    /// </summary>
    [JsonConverter(typeof(GetBlockDetailsByBlockHashFromCallbackRIBSJsonConverter))]
    [DataContract(Name = "GetBlockDetailsByBlockHashFromCallbackRIBS")]
    public partial class GetBlockDetailsByBlockHashFromCallbackRIBS : AbstractOpenAPISchema, IEquatable<GetBlockDetailsByBlockHashFromCallbackRIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSB.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSBC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSBC.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSBC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSL" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSL.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSL actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSD" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSD.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSD actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSD2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSD2.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSD2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSE" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSE.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSE actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSBSC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSBSC.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSBSC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSEC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSEC.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSEC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSZ" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSZ.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSZ actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSX" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSX.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSX actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSZ2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashFromCallbackRIBSZ2.</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBS(GetBlockDetailsByBlockHashFromCallbackRIBSZ2 actualInstance)
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
                if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSBC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSBSC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSD))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSD2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSE))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSEC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSL))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSX))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSZ))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashFromCallbackRIBSZ2))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GetBlockDetailsByBlockHashFromCallbackRIBSB, GetBlockDetailsByBlockHashFromCallbackRIBSBC, GetBlockDetailsByBlockHashFromCallbackRIBSBSC, GetBlockDetailsByBlockHashFromCallbackRIBSD, GetBlockDetailsByBlockHashFromCallbackRIBSD2, GetBlockDetailsByBlockHashFromCallbackRIBSE, GetBlockDetailsByBlockHashFromCallbackRIBSEC, GetBlockDetailsByBlockHashFromCallbackRIBSL, GetBlockDetailsByBlockHashFromCallbackRIBSX, GetBlockDetailsByBlockHashFromCallbackRIBSZ, GetBlockDetailsByBlockHashFromCallbackRIBSZ2");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSB`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSB</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSB GetGetBlockDetailsByBlockHashFromCallbackRIBSB()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSBC`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSBC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSBC</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSBC GetGetBlockDetailsByBlockHashFromCallbackRIBSBC()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSBC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSL`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSL`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSL</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSL GetGetBlockDetailsByBlockHashFromCallbackRIBSL()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSL)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSD`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSD`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSD</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSD GetGetBlockDetailsByBlockHashFromCallbackRIBSD()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSD)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSD2`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSD2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSD2</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSD2 GetGetBlockDetailsByBlockHashFromCallbackRIBSD2()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSD2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSE`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSE`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSE</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSE GetGetBlockDetailsByBlockHashFromCallbackRIBSE()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSE)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSBSC`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSBSC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSBSC</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSBSC GetGetBlockDetailsByBlockHashFromCallbackRIBSBSC()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSBSC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSEC`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSEC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSEC</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSEC GetGetBlockDetailsByBlockHashFromCallbackRIBSEC()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSEC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSZ`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSZ`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSZ</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSZ GetGetBlockDetailsByBlockHashFromCallbackRIBSZ()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSZ)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSX`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSX`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSX</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSX GetGetBlockDetailsByBlockHashFromCallbackRIBSX()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSX)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashFromCallbackRIBSZ2`. If the actual instance is not `GetBlockDetailsByBlockHashFromCallbackRIBSZ2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBSZ2</returns>
        public GetBlockDetailsByBlockHashFromCallbackRIBSZ2 GetGetBlockDetailsByBlockHashFromCallbackRIBSZ2()
        {
            return (GetBlockDetailsByBlockHashFromCallbackRIBSZ2)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBlockDetailsByBlockHashFromCallbackRIBS {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetBlockDetailsByBlockHashFromCallbackRIBS
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetBlockDetailsByBlockHashFromCallbackRIBS</returns>
        public static GetBlockDetailsByBlockHashFromCallbackRIBS FromJson(string jsonString)
        {
            GetBlockDetailsByBlockHashFromCallbackRIBS newGetBlockDetailsByBlockHashFromCallbackRIBS = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetBlockDetailsByBlockHashFromCallbackRIBS;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSB).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSB>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSB>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSB: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSBC).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSBC>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSBC>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSBC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSBC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSBSC).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSBSC>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSBSC>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSBSC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSBSC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSD).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSD>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSD>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSD");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSD: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSD2).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSD2>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSD2>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSD2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSD2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSE).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSE>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSE>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSE");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSE: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSEC).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSEC>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSEC>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSEC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSEC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSL).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSL>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSL>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSL");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSL: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSX).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSX>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSX>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSX");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSX: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSZ).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSZ>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSZ>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSZ");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSZ: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashFromCallbackRIBSZ2).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSZ2>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashFromCallbackRIBS = new GetBlockDetailsByBlockHashFromCallbackRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashFromCallbackRIBSZ2>(jsonString, GetBlockDetailsByBlockHashFromCallbackRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashFromCallbackRIBSZ2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashFromCallbackRIBSZ2: {1}", jsonString, exception.ToString()));
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
            return newGetBlockDetailsByBlockHashFromCallbackRIBS;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetBlockDetailsByBlockHashFromCallbackRIBS);
        }

        /// <summary>
        /// Returns true if GetBlockDetailsByBlockHashFromCallbackRIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockDetailsByBlockHashFromCallbackRIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockDetailsByBlockHashFromCallbackRIBS input)
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
    /// Custom JSON converter for GetBlockDetailsByBlockHashFromCallbackRIBS
    /// </summary>
    public class GetBlockDetailsByBlockHashFromCallbackRIBSJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetBlockDetailsByBlockHashFromCallbackRIBS).GetMethod("ToJson").Invoke(value, null)));
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
                return GetBlockDetailsByBlockHashFromCallbackRIBS.FromJson(JObject.Load(reader).ToString(Formatting.None));
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