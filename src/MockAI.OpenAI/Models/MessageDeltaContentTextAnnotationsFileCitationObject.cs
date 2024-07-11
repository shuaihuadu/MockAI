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
    /// A citation within the message that points to a specific quote from a specific File associated with the assistant or the message. Generated when the assistant uses the \&quot;file_search\&quot; tool to search files.
    /// </summary>
    [DataContract]
    public partial class MessageDeltaContentTextAnnotationsFileCitationObject : IEquatable<MessageDeltaContentTextAnnotationsFileCitationObject>, OneOfMessageDeltaContentTextObjectTextAnnotationsItems 
    { 
        /// <summary>
        /// The index of the annotation in the text content part.
        /// </summary>
        /// <value>The index of the annotation in the text content part.</value>
        [Required]

        [DataMember(Name="index")]
        public int? Index { get; set; }

        /// <summary>
        /// Always `file_citation`.
        /// </summary>
        /// <value>Always `file_citation`.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FileCitationEnum for file_citation
            /// </summary>
            [EnumMember(Value = "file_citation")]
            FileCitationEnum = 0        }

        /// <summary>
        /// Always &#x60;file_citation&#x60;.
        /// </summary>
        /// <value>Always &#x60;file_citation&#x60;.</value>
        [Required]

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        /// <value>The text in the message content that needs to be replaced.</value>

        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets FileCitation
        /// </summary>

        [DataMember(Name="file_citation")]
        public MessageDeltaContentTextAnnotationsFileCitationObjectFileCitation FileCitation { get; set; }

        /// <summary>
        /// Gets or Sets StartIndex
        /// </summary>

        [DataMember(Name="start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Gets or Sets EndIndex
        /// </summary>

        [DataMember(Name="end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageDeltaContentTextAnnotationsFileCitationObject {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  FileCitation: ").Append(FileCitation).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MessageDeltaContentTextAnnotationsFileCitationObject)obj);
        }

        /// <summary>
        /// Returns true if MessageDeltaContentTextAnnotationsFileCitationObject instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageDeltaContentTextAnnotationsFileCitationObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageDeltaContentTextAnnotationsFileCitationObject other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Index == other.Index ||
                    Index != null &&
                    Index.Equals(other.Index)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    FileCitation == other.FileCitation ||
                    FileCitation != null &&
                    FileCitation.Equals(other.FileCitation)
                ) && 
                (
                    StartIndex == other.StartIndex ||
                    StartIndex != null &&
                    StartIndex.Equals(other.StartIndex)
                ) && 
                (
                    EndIndex == other.EndIndex ||
                    EndIndex != null &&
                    EndIndex.Equals(other.EndIndex)
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
                    if (Index != null)
                    hashCode = hashCode * 59 + Index.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (FileCitation != null)
                    hashCode = hashCode * 59 + FileCitation.GetHashCode();
                    if (StartIndex != null)
                    hashCode = hashCode * 59 + StartIndex.GetHashCode();
                    if (EndIndex != null)
                    hashCode = hashCode * 59 + EndIndex.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MessageDeltaContentTextAnnotationsFileCitationObject left, MessageDeltaContentTextAnnotationsFileCitationObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MessageDeltaContentTextAnnotationsFileCitationObject left, MessageDeltaContentTextAnnotationsFileCitationObject right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}