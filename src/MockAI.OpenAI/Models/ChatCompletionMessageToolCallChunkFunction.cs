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
    public partial class ChatCompletionMessageToolCallChunkFunction : IEquatable<ChatCompletionMessageToolCallChunkFunction>
    { 
        /// <summary>
        /// The name of the function to call.
        /// </summary>
        /// <value>The name of the function to call.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The arguments to call the function with, as generated by the model in JSON format. Note that the model does not always generate valid JSON, and may hallucinate parameters not defined by your function schema. Validate the arguments in your code before calling your function.
        /// </summary>
        /// <value>The arguments to call the function with, as generated by the model in JSON format. Note that the model does not always generate valid JSON, and may hallucinate parameters not defined by your function schema. Validate the arguments in your code before calling your function.</value>

        [DataMember(Name="arguments")]
        public string Arguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatCompletionMessageToolCallChunkFunction {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ChatCompletionMessageToolCallChunkFunction)obj);
        }

        /// <summary>
        /// Returns true if ChatCompletionMessageToolCallChunkFunction instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatCompletionMessageToolCallChunkFunction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatCompletionMessageToolCallChunkFunction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Arguments == other.Arguments ||
                    Arguments != null &&
                    Arguments.Equals(other.Arguments)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Arguments != null)
                    hashCode = hashCode * 59 + Arguments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChatCompletionMessageToolCallChunkFunction left, ChatCompletionMessageToolCallChunkFunction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChatCompletionMessageToolCallChunkFunction left, ChatCompletionMessageToolCallChunkFunction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
