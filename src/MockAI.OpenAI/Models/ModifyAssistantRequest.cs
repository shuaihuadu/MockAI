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
    public partial class ModifyAssistantRequest : IEquatable<ModifyAssistantRequest>
    { 
        /// <summary>
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. 
        /// </summary>
        /// <value>ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them. </value>

        [DataMember(Name="model")]
        public AnyOfModifyAssistantRequestModel Model { get; set; }

        /// <summary>
        /// The name of the assistant. The maximum length is 256 characters. 
        /// </summary>
        /// <value>The name of the assistant. The maximum length is 256 characters. </value>

        [MaxLength(256)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The description of the assistant. The maximum length is 512 characters. 
        /// </summary>
        /// <value>The description of the assistant. The maximum length is 512 characters. </value>

        [MaxLength(512)]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// The system instructions that the assistant uses. The maximum length is 256,000 characters. 
        /// </summary>
        /// <value>The system instructions that the assistant uses. The maximum length is 256,000 characters. </value>

        [MaxLength(256000)]
        [DataMember(Name="instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types &#x60;code_interpreter&#x60;, &#x60;file_search&#x60;, or &#x60;function&#x60;. 
        /// </summary>
        /// <value>A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types &#x60;code_interpreter&#x60;, &#x60;file_search&#x60;, or &#x60;function&#x60;. </value>

        [DataMember(Name="tools")]
        public List<OneOfModifyAssistantRequestToolsItems> Tools { get; set; }

        /// <summary>
        /// Gets or Sets ToolResources
        /// </summary>

        [DataMember(Name="tool_resources")]
        public ModifyAssistantRequestToolResources ToolResources { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. 
        /// </summary>
        /// <value>Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </value>

        [DataMember(Name="metadata")]
        public Object Metadata { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. 
        /// </summary>
        /// <value>What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. </value>

        [Range(0, 2)]
        [DataMember(Name="temperature")]
        public decimal? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or temperature but not both. 
        /// </summary>
        /// <value>An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.  We generally recommend altering this or temperature but not both. </value>

        [Range(0, 1)]
        [DataMember(Name="top_p")]
        public decimal? TopP { get; set; }

        /// <summary>
        /// Gets or Sets ResponseFormat
        /// </summary>

        [DataMember(Name="response_format")]
        public AssistantsApiResponseFormatOption ResponseFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyAssistantRequest {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  Tools: ").Append(Tools).Append("\n");
            sb.Append("  ToolResources: ").Append(ToolResources).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  TopP: ").Append(TopP).Append("\n");
            sb.Append("  ResponseFormat: ").Append(ResponseFormat).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ModifyAssistantRequest)obj);
        }

        /// <summary>
        /// Returns true if ModifyAssistantRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ModifyAssistantRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyAssistantRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Model == other.Model ||
                    Model != null &&
                    Model.Equals(other.Model)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Instructions == other.Instructions ||
                    Instructions != null &&
                    Instructions.Equals(other.Instructions)
                ) && 
                (
                    Tools == other.Tools ||
                    Tools != null &&
                    Tools.SequenceEqual(other.Tools)
                ) && 
                (
                    ToolResources == other.ToolResources ||
                    ToolResources != null &&
                    ToolResources.Equals(other.ToolResources)
                ) && 
                (
                    Metadata == other.Metadata ||
                    Metadata != null &&
                    Metadata.Equals(other.Metadata)
                ) && 
                (
                    Temperature == other.Temperature ||
                    Temperature != null &&
                    Temperature.Equals(other.Temperature)
                ) && 
                (
                    TopP == other.TopP ||
                    TopP != null &&
                    TopP.Equals(other.TopP)
                ) && 
                (
                    ResponseFormat == other.ResponseFormat ||
                    ResponseFormat != null &&
                    ResponseFormat.Equals(other.ResponseFormat)
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
                    if (Model != null)
                    hashCode = hashCode * 59 + Model.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Instructions != null)
                    hashCode = hashCode * 59 + Instructions.GetHashCode();
                    if (Tools != null)
                    hashCode = hashCode * 59 + Tools.GetHashCode();
                    if (ToolResources != null)
                    hashCode = hashCode * 59 + ToolResources.GetHashCode();
                    if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                    if (Temperature != null)
                    hashCode = hashCode * 59 + Temperature.GetHashCode();
                    if (TopP != null)
                    hashCode = hashCode * 59 + TopP.GetHashCode();
                    if (ResponseFormat != null)
                    hashCode = hashCode * 59 + ResponseFormat.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ModifyAssistantRequest left, ModifyAssistantRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ModifyAssistantRequest left, ModifyAssistantRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}