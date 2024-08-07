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
    /// A list of files attached to a vector store.
    /// </summary>
    [DataContract]
    public partial class VectorStoreFileObject : IEquatable<VectorStoreFileObject>
    { 
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        /// <value>The identifier, which can be referenced in API endpoints.</value>
        [Required]

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// The object type, which is always `vector_store.file`.
        /// </summary>
        /// <value>The object type, which is always `vector_store.file`.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum VectorStoreFileEnum for vector_store.file
            /// </summary>
            [EnumMember(Value = "vector_store.file")]
            VectorStoreFileEnum = 0        }

        /// <summary>
        /// The object type, which is always &#x60;vector_store.file&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;vector_store.file&#x60;.</value>
        [Required]

        [DataMember(Name="object")]
        public ObjectEnum? _Object { get; set; }

        /// <summary>
        /// The total vector store usage in bytes. Note that this may be different from the original file size.
        /// </summary>
        /// <value>The total vector store usage in bytes. Note that this may be different from the original file size.</value>
        [Required]

        [DataMember(Name="usage_bytes")]
        public int? UsageBytes { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store file was created.
        /// </summary>
        /// <value>The Unix timestamp (in seconds) for when the vector store file was created.</value>
        [Required]

        [DataMember(Name="created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </summary>
        /// <value>The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.</value>
        [Required]

        [DataMember(Name="vector_store_id")]
        public string VectorStoreId { get; set; }

        /// <summary>
        /// The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.
        /// </summary>
        /// <value>The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum InProgressEnum for in_progress
            /// </summary>
            [EnumMember(Value = "in_progress")]
            InProgressEnum = 0,
            /// <summary>
            /// Enum CompletedEnum for completed
            /// </summary>
            [EnumMember(Value = "completed")]
            CompletedEnum = 1,
            /// <summary>
            /// Enum CancelledEnum for cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            CancelledEnum = 2,
            /// <summary>
            /// Enum FailedEnum for failed
            /// </summary>
            [EnumMember(Value = "failed")]
            FailedEnum = 3        }

        /// <summary>
        /// The status of the vector store file, which can be either &#x60;in_progress&#x60;, &#x60;completed&#x60;, &#x60;cancelled&#x60;, or &#x60;failed&#x60;. The status &#x60;completed&#x60; indicates that the vector store file is ready for use.
        /// </summary>
        /// <value>The status of the vector store file, which can be either &#x60;in_progress&#x60;, &#x60;completed&#x60;, &#x60;cancelled&#x60;, or &#x60;failed&#x60;. The status &#x60;completed&#x60; indicates that the vector store file is ready for use.</value>
        [Required]

        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets LastError
        /// </summary>
        [Required]

        [DataMember(Name="last_error")]
        public VectorStoreFileObjectLastError LastError { get; set; }

        /// <summary>
        /// The strategy used to chunk the file.
        /// </summary>
        /// <value>The strategy used to chunk the file.</value>

        [DataMember(Name="chunking_strategy")]
        public OneOfVectorStoreFileObjectChunkingStrategy ChunkingStrategy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VectorStoreFileObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  UsageBytes: ").Append(UsageBytes).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  VectorStoreId: ").Append(VectorStoreId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastError: ").Append(LastError).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VectorStoreFileObject)obj);
        }

        /// <summary>
        /// Returns true if VectorStoreFileObject instances are equal
        /// </summary>
        /// <param name="other">Instance of VectorStoreFileObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VectorStoreFileObject other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    _Object == other._Object ||
                    _Object != null &&
                    _Object.Equals(other._Object)
                ) && 
                (
                    UsageBytes == other.UsageBytes ||
                    UsageBytes != null &&
                    UsageBytes.Equals(other.UsageBytes)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    VectorStoreId == other.VectorStoreId ||
                    VectorStoreId != null &&
                    VectorStoreId.Equals(other.VectorStoreId)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    LastError == other.LastError ||
                    LastError != null &&
                    LastError.Equals(other.LastError)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (_Object != null)
                    hashCode = hashCode * 59 + _Object.GetHashCode();
                    if (UsageBytes != null)
                    hashCode = hashCode * 59 + UsageBytes.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (VectorStoreId != null)
                    hashCode = hashCode * 59 + VectorStoreId.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (LastError != null)
                    hashCode = hashCode * 59 + LastError.GetHashCode();
                    if (ChunkingStrategy != null)
                    hashCode = hashCode * 59 + ChunkingStrategy.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VectorStoreFileObject left, VectorStoreFileObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VectorStoreFileObject left, VectorStoreFileObject right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
