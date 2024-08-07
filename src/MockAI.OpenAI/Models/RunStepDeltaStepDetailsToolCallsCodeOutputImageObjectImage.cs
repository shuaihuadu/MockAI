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
    public partial class RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage : IEquatable<RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage>
    { 
        /// <summary>
        /// The [file](/docs/api-reference/files) ID of the image.
        /// </summary>
        /// <value>The [file](/docs/api-reference/files) ID of the image.</value>

        [DataMember(Name="file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage)obj);
        }

        /// <summary>
        /// Returns true if RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage instances are equal
        /// </summary>
        /// <param name="other">Instance of RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FileId == other.FileId ||
                    FileId != null &&
                    FileId.Equals(other.FileId)
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
                    if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage left, RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage left, RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
