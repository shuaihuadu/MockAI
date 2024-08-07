/*
 * OpenAI API
 *
 * The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
 *
 * OpenAPI spec version: 2.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CreateCompletionResponseChoices : IEquatable<CreateCompletionResponseChoices>
    { 
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, or `content_filter` if content was omitted due to a flag from our content filters. 
        /// </summary>
        /// <value>The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, or `content_filter` if content was omitted due to a flag from our content filters. </value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum FinishReasonEnum
        {
            /// <summary>
            /// Enum StopEnum for stop
            /// </summary>
            [EnumMember(Value = "stop")]
            StopEnum = 0,
            /// <summary>
            /// Enum LengthEnum for length
            /// </summary>
            [EnumMember(Value = "length")]
            LengthEnum = 1,
            /// <summary>
            /// Enum ContentFilterEnum for content_filter
            /// </summary>
            [EnumMember(Value = "content_filter")]
            ContentFilterEnum = 2        }

        /// <summary>
        /// The reason the model stopped generating tokens. This will be &#x60;stop&#x60; if the model hit a natural stop point or a provided stop sequence, &#x60;length&#x60; if the maximum number of tokens specified in the request was reached, or &#x60;content_filter&#x60; if content was omitted due to a flag from our content filters. 
        /// </summary>
        /// <value>The reason the model stopped generating tokens. This will be &#x60;stop&#x60; if the model hit a natural stop point or a provided stop sequence, &#x60;length&#x60; if the maximum number of tokens specified in the request was reached, or &#x60;content_filter&#x60; if content was omitted due to a flag from our content filters. </value>
        [Required]

        [DataMember(Name="finish_reason")]
        public FinishReasonEnum? FinishReason { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [Required]

        [DataMember(Name="index")]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets Logprobs
        /// </summary>
        [Required]

        [DataMember(Name="logprobs")]
        public CreateCompletionResponseLogprobs Logprobs { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [Required]

        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCompletionResponseChoices {\n");
            sb.Append("  FinishReason: ").Append(FinishReason).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Logprobs: ").Append(Logprobs).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CreateCompletionResponseChoices)obj);
        }

        /// <summary>
        /// Returns true if CreateCompletionResponseChoices instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCompletionResponseChoices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCompletionResponseChoices other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FinishReason == other.FinishReason ||
                    FinishReason != null &&
                    FinishReason.Equals(other.FinishReason)
                ) && 
                (
                    Index == other.Index ||
                    Index != null &&
                    Index.Equals(other.Index)
                ) && 
                (
                    Logprobs == other.Logprobs ||
                    Logprobs != null &&
                    Logprobs.Equals(other.Logprobs)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (FinishReason != null)
                    hashCode = hashCode * 59 + FinishReason.GetHashCode();
                    if (Index != null)
                    hashCode = hashCode * 59 + Index.GetHashCode();
                    if (Logprobs != null)
                    hashCode = hashCode * 59 + Logprobs.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateCompletionResponseChoices left, CreateCompletionResponseChoices right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateCompletionResponseChoices left, CreateCompletionResponseChoices right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
