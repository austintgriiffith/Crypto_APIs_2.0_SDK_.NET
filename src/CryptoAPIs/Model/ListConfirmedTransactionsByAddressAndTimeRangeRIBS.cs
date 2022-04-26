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
    /// ListConfirmedTransactionsByAddressAndTimeRangeRIBS
    /// </summary>
    [JsonConverter(typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSJsonConverter))]
    [DataContract(Name = "ListConfirmedTransactionsByAddressAndTimeRangeRIBS")]
    public partial class ListConfirmedTransactionsByAddressAndTimeRangeRIBS : AbstractOpenAPISchema, IEquatable<ListConfirmedTransactionsByAddressAndTimeRangeRIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSB.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSL" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSL.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSL actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSD" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSD.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSD actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSE" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSE.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSE actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBS" /> class
        /// with the <see cref="ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ.</param>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBS(ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ actualInstance)
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
                if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSD))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSE))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSL))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ListConfirmedTransactionsByAddressAndTimeRangeRIBSB, ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC, ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC, ListConfirmedTransactionsByAddressAndTimeRangeRIBSD, ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2, ListConfirmedTransactionsByAddressAndTimeRangeRIBSE, ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC, ListConfirmedTransactionsByAddressAndTimeRangeRIBSL, ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSB`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSB</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSB GetListConfirmedTransactionsByAddressAndTimeRangeRIBSB()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC GetListConfirmedTransactionsByAddressAndTimeRangeRIBSBC()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSL`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSL`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSL</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSL GetListConfirmedTransactionsByAddressAndTimeRangeRIBSL()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSL)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSD`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSD`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSD</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSD GetListConfirmedTransactionsByAddressAndTimeRangeRIBSD()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSD)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2 GetListConfirmedTransactionsByAddressAndTimeRangeRIBSD2()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC GetListConfirmedTransactionsByAddressAndTimeRangeRIBSEC()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSE`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSE`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSE</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSE GetListConfirmedTransactionsByAddressAndTimeRangeRIBSE()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSE)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC GetListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ`. If the actual instance is not `ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ</returns>
        public ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ GetListConfirmedTransactionsByAddressAndTimeRangeRIBSZ()
        {
            return (ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfirmedTransactionsByAddressAndTimeRangeRIBS {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBS
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBS</returns>
        public static ListConfirmedTransactionsByAddressAndTimeRangeRIBS FromJson(string jsonString)
        {
            ListConfirmedTransactionsByAddressAndTimeRangeRIBS newListConfirmedTransactionsByAddressAndTimeRangeRIBS = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newListConfirmedTransactionsByAddressAndTimeRangeRIBS;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSB).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSB>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSB>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSB: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSBSC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSD).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSD>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSD>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSD");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSD: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSD2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSE).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSE>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSE>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSE");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSE: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSEC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSL).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSL>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSL>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSL");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSL: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ).GetProperty("AdditionalProperties") == null)
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.SerializerSettings));
                }
                else
                {
                    newListConfirmedTransactionsByAddressAndTimeRangeRIBS = new ListConfirmedTransactionsByAddressAndTimeRangeRIBS(JsonConvert.DeserializeObject<ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ>(jsonString, ListConfirmedTransactionsByAddressAndTimeRangeRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListConfirmedTransactionsByAddressAndTimeRangeRIBSZ: {1}", jsonString, exception.ToString()));
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
            return newListConfirmedTransactionsByAddressAndTimeRangeRIBS;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfirmedTransactionsByAddressAndTimeRangeRIBS);
        }

        /// <summary>
        /// Returns true if ListConfirmedTransactionsByAddressAndTimeRangeRIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of ListConfirmedTransactionsByAddressAndTimeRangeRIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListConfirmedTransactionsByAddressAndTimeRangeRIBS input)
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
    /// Custom JSON converter for ListConfirmedTransactionsByAddressAndTimeRangeRIBS
    /// </summary>
    public class ListConfirmedTransactionsByAddressAndTimeRangeRIBSJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ListConfirmedTransactionsByAddressAndTimeRangeRIBS).GetMethod("ToJson").Invoke(value, null)));
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
                return ListConfirmedTransactionsByAddressAndTimeRangeRIBS.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
