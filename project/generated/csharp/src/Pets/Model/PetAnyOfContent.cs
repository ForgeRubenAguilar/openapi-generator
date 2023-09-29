/*
 * TEST
 *
 * ## TEST
 *
 * The version of the OpenAPI document: 1.0.0
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
using FileParameter = Pets.Client.FileParameter;
using OpenAPIDateConverter = Pets.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Pets.Model
{
// Template originated on version found here: https://github.com/OpenAPITools/openapi-generator/blob/v7.0.1/modules/openapi-generator/src/main/resources/csharp/modelAnyOf.mustache

    /// <summary>
    /// Pet object that needs to be added to the store
    /// </summary>
    [JsonConverter(typeof(PetAnyOfContentJsonConverter))]
    [DataContract(Name = "PetAnyOf_content")]
    public partial class PetAnyOfContent : AbstractOpenAPISchema, IEquatable<PetAnyOfContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetAnyOfContent" /> class.
        /// </summary>
        internal PetAnyOfContent(Object actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PetAnyOfContent" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public PetAnyOfContent(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetAnyOfContent" /> class
        /// with the <see cref="bool" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of bool.</param>
        public PetAnyOfContent(bool actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetAnyOfContent" /> class
        /// with the <see cref="PetSubId" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PetSubId.</param>
        public PetAnyOfContent(PetSubId actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
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
                if (value.GetType() == typeof(PetSubId))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(bool))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: PetSubId, bool, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `bool`. If the actual instance is not `bool`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of bool</returns>
        public bool GetBool()
        {
            return (bool)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PetSubId`. If the actual instance is not `PetSubId`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PetSubId</returns>
        public PetSubId GetPetSubId()
        {
            return (PetSubId)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PetAnyOfContent {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, PetAnyOfContent.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PetAnyOfContent
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PetAnyOfContent</returns>
        public static PetAnyOfContent FromJson(string jsonString)
        {
            PetAnyOfContent newPetAnyOfContent = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPetAnyOfContent;
            }

            try
            {
                newPetAnyOfContent = new PetAnyOfContent(JsonConvert.DeserializeObject<PetSubId>(jsonString, PetAnyOfContent.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPetAnyOfContent;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PetSubId: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newPetAnyOfContent = new PetAnyOfContent(JsonConvert.DeserializeObject<bool>(jsonString, PetAnyOfContent.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPetAnyOfContent;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into bool: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newPetAnyOfContent = new PetAnyOfContent(JsonConvert.DeserializeObject<string>(jsonString, PetAnyOfContent.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPetAnyOfContent;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PetAnyOfContent);
        }

        /// <summary>
        /// Returns true if PetAnyOfContent instances are equal
        /// </summary>
        /// <param name="input">Instance of PetAnyOfContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PetAnyOfContent input)
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
    /// Custom JSON converter for PetAnyOfContent
    /// </summary>
    public class PetAnyOfContentJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PetAnyOfContent).GetMethod("ToJson").Invoke(value, null)));
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
            switch(reader.TokenType) 
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                case JsonToken.Date:
                    return new PetAnyOfContent(reader.Value);
                case JsonToken.StartObject:
                    return PetAnyOfContent.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return PetAnyOfContent.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
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
