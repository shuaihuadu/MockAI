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
    public partial class TranscriptionWord : IEquatable<TranscriptionWord>
    { 
        /// <summary>
        /// The text content of the word.
        /// </summary>
        /// <value>The text content of the word.</value>
        [Required]

        [DataMember(Name="word")]
        public string Word { get; set; }

        /// <summary>
        /// Start time of the word in seconds.
        /// </summary>
        /// <value>Start time of the word in seconds.</value>
        [Required]

        [DataMember(Name="start")]
        public float? Start { get; set; }

        /// <summary>
        /// End time of the word in seconds.
        /// </summary>
        /// <value>End time of the word in seconds.</value>
        [Required]

        [DataMember(Name="end")]
        public float? End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionWord {\n");
            sb.Append("  Word: ").Append(Word).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TranscriptionWord)obj);
        }

        /// <summary>
        /// Returns true if TranscriptionWord instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionWord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionWord other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Word == other.Word ||
                    Word != null &&
                    Word.Equals(other.Word)
                ) && 
                (
                    Start == other.Start ||
                    Start != null &&
                    Start.Equals(other.Start)
                ) && 
                (
                    End == other.End ||
                    End != null &&
                    End.Equals(other.End)
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
                    if (Word != null)
                    hashCode = hashCode * 59 + Word.GetHashCode();
                    if (Start != null)
                    hashCode = hashCode * 59 + Start.GetHashCode();
                    if (End != null)
                    hashCode = hashCode * 59 + End.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TranscriptionWord left, TranscriptionWord right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TranscriptionWord left, TranscriptionWord right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}