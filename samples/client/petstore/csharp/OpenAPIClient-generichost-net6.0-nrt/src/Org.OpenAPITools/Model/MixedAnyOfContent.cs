// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Mixed anyOf types for testing
    /// </summary>
    public partial class MixedAnyOfContent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedAnyOfContent" /> class.
        /// </summary>
        /// <param name="varString"></param>
        /// <param name="varBool"></param>
        /// <param name="varInt"></param>
        /// <param name="varDecimal"></param>
        /// <param name="mixedSubId"></param>
        public MixedAnyOfContent(VarString? varString, VarBool? varBool, VarInt? varInt, VarDecimal? varDecimal, MixedSubId? mixedSubId)
        {
            VarString = varString;
            VarBool = varBool;
            VarInt = varInt;
            VarDecimal = varDecimal;
            MixedSubId = mixedSubId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        public string? String { get; set; }

        /// <summary>
        /// Gets or Sets Bool
        /// </summary>
        public bool? Bool { get; set; }

        /// <summary>
        /// Gets or Sets Int
        /// </summary>
        public int? Int { get; set; }

        /// <summary>
        /// Gets or Sets Decimal
        /// </summary>
        public decimal? Decimal { get; set; }

        /// <summary>
        /// Gets or Sets MixedSubId
        /// </summary>
        public MixedSubId? MixedSubId { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MixedAnyOfContent {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
    /// A Json converter for type <see cref="MixedAnyOfContent" />
    /// </summary>
    public class MixedAnyOfContentJsonConverter : JsonConverter<MixedAnyOfContent>
    {
        /// <summary>
        /// Deserializes json to <see cref="MixedAnyOfContent" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MixedAnyOfContent Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? varString = default;
            bool? varBool = default;
            int? varInt = default;
            decimal? varDecimal = default;
            MixedSubId? mixedSubId = default;

            Utf8JsonReader utf8JsonReaderAnyOf = utf8JsonReader;
            while (utf8JsonReaderAnyOf.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderAnyOf.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderAnyOf.CurrentDepth)
                    break;

                if (utf8JsonReaderAnyOf.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderAnyOf.CurrentDepth - 1)
                {
                    Utf8JsonReader utf8JsonReaderVarString = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<string?>(ref utf8JsonReaderVarString, jsonSerializerOptions, out varString);

                    Utf8JsonReader utf8JsonReaderVarBool = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<bool?>(ref utf8JsonReaderVarBool, jsonSerializerOptions, out varBool);

                    Utf8JsonReader utf8JsonReaderVarInt = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<int?>(ref utf8JsonReaderVarInt, jsonSerializerOptions, out varInt);

                    Utf8JsonReader utf8JsonReaderVarDecimal = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<decimal?>(ref utf8JsonReaderVarDecimal, jsonSerializerOptions, out varDecimal);

                    Utf8JsonReader utf8JsonReaderMixedSubId = utf8JsonReader;
                    OpenAPIClientUtils.TryDeserialize<MixedSubId?>(ref utf8JsonReaderMixedSubId, jsonSerializerOptions, out mixedSubId);
                }
            }

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        default:
                            break;
                    }
                }
            }

            return new MixedAnyOfContent(varString, varBool, varInt, varDecimal, mixedSubId);
        }

        /// <summary>
        /// Serializes a <see cref="MixedAnyOfContent" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedAnyOfContent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MixedAnyOfContent mixedAnyOfContent, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (mixedAnyOfContent.string != null)
            {
                stringJsonConverter stringJsonConverter = (stringJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mixedAnyOfContent.string.GetType()));
                stringJsonConverter.WriteProperties(ref writer, mixedAnyOfContent.string, jsonSerializerOptions);
            }

            if (mixedAnyOfContent.bool != null)
            {
                boolJsonConverter boolJsonConverter = (boolJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mixedAnyOfContent.bool.GetType()));
                boolJsonConverter.WriteProperties(ref writer, mixedAnyOfContent.bool, jsonSerializerOptions);
            }

            if (mixedAnyOfContent.int != null)
            {
                intJsonConverter intJsonConverter = (intJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mixedAnyOfContent.int.GetType()));
                intJsonConverter.WriteProperties(ref writer, mixedAnyOfContent.int, jsonSerializerOptions);
            }

            if (mixedAnyOfContent.decimal != null)
            {
                decimalJsonConverter decimalJsonConverter = (decimalJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mixedAnyOfContent.decimal.GetType()));
                decimalJsonConverter.WriteProperties(ref writer, mixedAnyOfContent.decimal, jsonSerializerOptions);
            }

            if (mixedAnyOfContent.MixedSubId != null)
            {
                MixedSubIdJsonConverter MixedSubIdJsonConverter = (MixedSubIdJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(mixedAnyOfContent.MixedSubId.GetType()));
                MixedSubIdJsonConverter.WriteProperties(ref writer, mixedAnyOfContent.MixedSubId, jsonSerializerOptions);
            }

            WriteProperties(ref writer, mixedAnyOfContent, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MixedAnyOfContent" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedAnyOfContent"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, MixedAnyOfContent mixedAnyOfContent, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
