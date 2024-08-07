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
    /// Options for streaming response. Only set this when you set &#x60;stream: true&#x60;. 
    /// </summary>
    [DataContract]
    public partial class ChatCompletionStreamOptions : IEquatable<ChatCompletionStreamOptions>
    { 
        /// <summary>
        /// If set, an additional chunk will be streamed before the &#x60;data: [DONE]&#x60; message. The &#x60;usage&#x60; field on this chunk shows the token usage statistics for the entire request, and the &#x60;choices&#x60; field will always be an empty array. All other chunks will also include a &#x60;usage&#x60; field, but with a null value. 
        /// </summary>
        /// <value>If set, an additional chunk will be streamed before the &#x60;data: [DONE]&#x60; message. The &#x60;usage&#x60; field on this chunk shows the token usage statistics for the entire request, and the &#x60;choices&#x60; field will always be an empty array. All other chunks will also include a &#x60;usage&#x60; field, but with a null value. </value>

        [DataMember(Name="include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatCompletionStreamOptions {\n");
            sb.Append("  IncludeUsage: ").Append(IncludeUsage).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ChatCompletionStreamOptions)obj);
        }

        /// <summary>
        /// Returns true if ChatCompletionStreamOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatCompletionStreamOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatCompletionStreamOptions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IncludeUsage == other.IncludeUsage ||
                    IncludeUsage != null &&
                    IncludeUsage.Equals(other.IncludeUsage)
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
                    if (IncludeUsage != null)
                    hashCode = hashCode * 59 + IncludeUsage.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChatCompletionStreamOptions left, ChatCompletionStreamOptions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChatCompletionStreamOptions left, ChatCompletionStreamOptions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
