/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Fruit
    /// </summary>
    [JsonConverter(typeof(FruitJsonConverter))]
    [DataContract(Name = "fruit")]
    public partial class Fruit : AbstractOpenAPISchema, IEquatable<Fruit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit" /> class
        /// with the <see cref="Apple" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Apple.</param>
        public Fruit(Apple actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit" /> class
        /// with the <see cref="Banana" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Banana.</param>
        public Fruit(Banana actualInstance)
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
                if (value.GetType() == typeof(Apple))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Banana))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Apple, Banana");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Apple`. If the actual instance is not `Apple`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Apple</returns>
        public Apple GetApple()
        {
            return (Apple)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Banana`. If the actual instance is not `Banana`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Banana</returns>
        public Banana GetBanana()
        {
            return (Banana)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fruit {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Fruit.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Fruit
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Fruit</returns>
        public static Fruit FromJson(string jsonString)
        {
            Fruit newFruit = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newFruit;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Apple).GetProperty("AdditionalProperties") == null)
                {
                    newFruit = new Fruit(JsonConvert.DeserializeObject<Apple>(jsonString, Fruit.SerializerSettings));
                }
                else
                {
                    newFruit = new Fruit(JsonConvert.DeserializeObject<Apple>(jsonString, Fruit.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Apple");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Apple: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Banana).GetProperty("AdditionalProperties") == null)
                {
                    newFruit = new Fruit(JsonConvert.DeserializeObject<Banana>(jsonString, Fruit.SerializerSettings));
                }
                else
                {
                    newFruit = new Fruit(JsonConvert.DeserializeObject<Banana>(jsonString, Fruit.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Banana");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Banana: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newFruit;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Fruit).AreEqual;
        }

        /// <summary>
        /// Returns true if Fruit instances are equal
        /// </summary>
        /// <param name="input">Instance of Fruit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fruit input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
    /// Custom JSON converter for Fruit
    /// </summary>
    public class FruitJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Fruit).GetMethod("ToJson").Invoke(value, null)));
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
                case JsonToken.StartObject:
                    return Fruit.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Fruit.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
