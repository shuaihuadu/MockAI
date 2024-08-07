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
    /// The delta containing the fields that have changed on the run step.
    /// </summary>
    [DataContract]
    public partial class RunStepDeltaObjectDelta : IEquatable<RunStepDeltaObjectDelta>
    { 
        /// <summary>
        /// The details of the run step.
        /// </summary>
        /// <value>The details of the run step.</value>

        [DataMember(Name="step_details")]
        public OneOfRunStepDeltaObjectDeltaStepDetails StepDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunStepDeltaObjectDelta {\n");
            sb.Append("  StepDetails: ").Append(StepDetails).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RunStepDeltaObjectDelta)obj);
        }

        /// <summary>
        /// Returns true if RunStepDeltaObjectDelta instances are equal
        /// </summary>
        /// <param name="other">Instance of RunStepDeltaObjectDelta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunStepDeltaObjectDelta other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StepDetails == other.StepDetails ||
                    StepDetails != null &&
                    StepDetails.Equals(other.StepDetails)
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
                    if (StepDetails != null)
                    hashCode = hashCode * 59 + StepDetails.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RunStepDeltaObjectDelta left, RunStepDeltaObjectDelta right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RunStepDeltaObjectDelta left, RunStepDeltaObjectDelta right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
