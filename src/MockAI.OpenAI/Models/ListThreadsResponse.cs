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
    public partial class ListThreadsResponse : IEquatable<ListThreadsResponse>
    { 
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [Required]

        [DataMember(Name="object")]
        public string _Object { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [Required]

        [DataMember(Name="data")]
        public List<ThreadObject> Data { get; set; }

        /// <summary>
        /// Gets or Sets FirstId
        /// </summary>
        [Required]

        [DataMember(Name="first_id")]
        public string FirstId { get; set; }

        /// <summary>
        /// Gets or Sets LastId
        /// </summary>
        [Required]

        [DataMember(Name="last_id")]
        public string LastId { get; set; }

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [Required]

        [DataMember(Name="has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListThreadsResponse {\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  FirstId: ").Append(FirstId).Append("\n");
            sb.Append("  LastId: ").Append(LastId).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ListThreadsResponse)obj);
        }

        /// <summary>
        /// Returns true if ListThreadsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ListThreadsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListThreadsResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    _Object == other._Object ||
                    _Object != null &&
                    _Object.Equals(other._Object)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.SequenceEqual(other.Data)
                ) && 
                (
                    FirstId == other.FirstId ||
                    FirstId != null &&
                    FirstId.Equals(other.FirstId)
                ) && 
                (
                    LastId == other.LastId ||
                    LastId != null &&
                    LastId.Equals(other.LastId)
                ) && 
                (
                    HasMore == other.HasMore ||
                    HasMore != null &&
                    HasMore.Equals(other.HasMore)
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
                    if (_Object != null)
                    hashCode = hashCode * 59 + _Object.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (FirstId != null)
                    hashCode = hashCode * 59 + FirstId.GetHashCode();
                    if (LastId != null)
                    hashCode = hashCode * 59 + LastId.GetHashCode();
                    if (HasMore != null)
                    hashCode = hashCode * 59 + HasMore.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ListThreadsResponse left, ListThreadsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ListThreadsResponse left, ListThreadsResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
