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
    /// References an image URL in the content of a message.
    /// </summary>
    [DataContract]
    public partial class MessageDeltaContentImageUrlObject : IEquatable<MessageDeltaContentImageUrlObject>, OneOfMessageDeltaObjectDeltaContentItems 
    { 
        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        /// <value>The index of the content part in the message.</value>
        [Required]

        [DataMember(Name="index")]
        public int? Index { get; set; }

        /// <summary>
        /// Always `image_url`.
        /// </summary>
        /// <value>Always `image_url`.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ImageUrlEnum for image_url
            /// </summary>
            [EnumMember(Value = "image_url")]
            ImageUrlEnum = 0        }

        /// <summary>
        /// Always &#x60;image_url&#x60;.
        /// </summary>
        /// <value>Always &#x60;image_url&#x60;.</value>
        [Required]

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>

        [DataMember(Name="image_url")]
        public MessageDeltaContentImageUrlObjectImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageDeltaContentImageUrlObject {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MessageDeltaContentImageUrlObject)obj);
        }

        /// <summary>
        /// Returns true if MessageDeltaContentImageUrlObject instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageDeltaContentImageUrlObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageDeltaContentImageUrlObject other)
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
                    ImageUrl == other.ImageUrl ||
                    ImageUrl != null &&
                    ImageUrl.Equals(other.ImageUrl)
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
                    if (ImageUrl != null)
                    hashCode = hashCode * 59 + ImageUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MessageDeltaContentImageUrlObject left, MessageDeltaContentImageUrlObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MessageDeltaContentImageUrlObject left, MessageDeltaContentImageUrlObject right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
