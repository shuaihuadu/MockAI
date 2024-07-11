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
    public partial class CreateVectorStoreFileBatchRequest : IEquatable<CreateVectorStoreFileBatchRequest>
    { 
        /// <summary>
        /// A list of [File](/docs/api-reference/files) IDs that the vector store should use. Useful for tools like &#x60;file_search&#x60; that can access files.
        /// </summary>
        /// <value>A list of [File](/docs/api-reference/files) IDs that the vector store should use. Useful for tools like &#x60;file_search&#x60; that can access files.</value>
        [Required]

        [DataMember(Name="file_ids")]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// Gets or Sets ChunkingStrategy
        /// </summary>

        [DataMember(Name="chunking_strategy")]
        public ChunkingStrategyRequestParam ChunkingStrategy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVectorStoreFileBatchRequest {\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  ChunkingStrategy: ").Append(ChunkingStrategy).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateVectorStoreFileBatchRequest)obj);
        }

        /// <summary>
        /// Returns true if CreateVectorStoreFileBatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateVectorStoreFileBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateVectorStoreFileBatchRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FileIds == other.FileIds ||
                    FileIds != null &&
                    FileIds.SequenceEqual(other.FileIds)
                ) && 
                (
                    ChunkingStrategy == other.ChunkingStrategy ||
                    ChunkingStrategy != null &&
                    ChunkingStrategy.Equals(other.ChunkingStrategy)
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
                    if (FileIds != null)
                    hashCode = hashCode * 59 + FileIds.GetHashCode();
                    if (ChunkingStrategy != null)
                    hashCode = hashCode * 59 + ChunkingStrategy.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateVectorStoreFileBatchRequest left, CreateVectorStoreFileBatchRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateVectorStoreFileBatchRequest left, CreateVectorStoreFileBatchRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}