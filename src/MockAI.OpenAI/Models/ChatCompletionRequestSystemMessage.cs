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
    public partial class ChatCompletionRequestSystemMessage : IEquatable<ChatCompletionRequestSystemMessage>, ChatCompletionRequestMessage, OneOfFinetuneChatRequestInputMessagesItems 
    { 
        /// <summary>
        /// The contents of the system message.
        /// </summary>
        /// <value>The contents of the system message.</value>
        [Required]

        [DataMember(Name="content")]
        public string Content { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `system`.
        /// </summary>
        /// <value>The role of the messages author, in this case `system`.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum SystemEnum for system
            /// </summary>
            [EnumMember(Value = "system")]
            SystemEnum = 0        }

        /// <summary>
        /// The role of the messages author, in this case &#x60;system&#x60;.
        /// </summary>
        /// <value>The role of the messages author, in this case &#x60;system&#x60;.</value>
        [Required]

        [DataMember(Name="role")]
        public RoleEnum? Role { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        /// <value>An optional name for the participant. Provides the model information to differentiate between participants of the same role.</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatCompletionRequestSystemMessage {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ChatCompletionRequestSystemMessage)obj);
        }

        /// <summary>
        /// Returns true if ChatCompletionRequestSystemMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatCompletionRequestSystemMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatCompletionRequestSystemMessage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) && 
                (
                    Role == other.Role ||
                    Role != null &&
                    Role.Equals(other.Role)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (Role != null)
                    hashCode = hashCode * 59 + Role.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChatCompletionRequestSystemMessage left, ChatCompletionRequestSystemMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChatCompletionRequestSystemMessage left, ChatCompletionRequestSystemMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
