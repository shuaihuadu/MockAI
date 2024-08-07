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
    /// References an image [File](/docs/api-reference/files) in the content of a message.
    /// </summary>
    [DataContract]
    public partial class MessageContentImageFileObject : IEquatable<MessageContentImageFileObject>, OneOfMessageObjectContentItems 
    { 
        /// <summary>
        /// Always `image_file`.
        /// </summary>
        /// <value>Always `image_file`.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ImageFileEnum for image_file
            /// </summary>
            [EnumMember(Value = "image_file")]
            ImageFileEnum = 0        }

        /// <summary>
        /// Always &#x60;image_file&#x60;.
        /// </summary>
        /// <value>Always &#x60;image_file&#x60;.</value>
        [Required]

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets ImageFile
        /// </summary>
        [Required]

        [DataMember(Name="image_file")]
        public MessageContentImageFileObjectImageFile ImageFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageContentImageFileObject {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MessageContentImageFileObject)obj);
        }

        /// <summary>
        /// Returns true if MessageContentImageFileObject instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageContentImageFileObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageContentImageFileObject other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    ImageFile == other.ImageFile ||
                    ImageFile != null &&
                    ImageFile.Equals(other.ImageFile)
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
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (ImageFile != null)
                    hashCode = hashCode * 59 + ImageFile.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MessageContentImageFileObject left, MessageContentImageFileObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MessageContentImageFileObject left, MessageContentImageFileObject right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
