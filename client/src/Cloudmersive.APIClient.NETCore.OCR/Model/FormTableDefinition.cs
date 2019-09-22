/* 
 * ocrapi
 *
 * The powerful Optical Character Recognition (OCR) APIs let you convert scanned images of pages into recognized text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.OCR.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.OCR.Model
{
    /// <summary>
    /// Definition of a form table for OCR data extraction from images
    /// </summary>
    [DataContract]
    public partial class FormTableDefinition :  IEquatable<FormTableDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormTableDefinition" /> class.
        /// </summary>
        /// <param name="TableID">Optional; the ID of the table.</param>
        /// <param name="ColumnDefinitions">Definition of the columns in the table.</param>
        /// <param name="TargetTableHeightRelative">Optional - scale factor for target table height - relative to maximum height of headers of columns.</param>
        /// <param name="TargetRowHeightRelative">Optional - scale factor for target row height - relative to height of column header.</param>
        public FormTableDefinition(string TableID = default(string), List<FormTableColumnDefinition> ColumnDefinitions = default(List<FormTableColumnDefinition>), double? TargetTableHeightRelative = default(double?), double? TargetRowHeightRelative = default(double?))
        {
            this.TableID = TableID;
            this.ColumnDefinitions = ColumnDefinitions;
            this.TargetTableHeightRelative = TargetTableHeightRelative;
            this.TargetRowHeightRelative = TargetRowHeightRelative;
        }
        
        /// <summary>
        /// Optional; the ID of the table
        /// </summary>
        /// <value>Optional; the ID of the table</value>
        [DataMember(Name="TableID", EmitDefaultValue=false)]
        public string TableID { get; set; }

        /// <summary>
        /// Definition of the columns in the table
        /// </summary>
        /// <value>Definition of the columns in the table</value>
        [DataMember(Name="ColumnDefinitions", EmitDefaultValue=false)]
        public List<FormTableColumnDefinition> ColumnDefinitions { get; set; }

        /// <summary>
        /// Optional - scale factor for target table height - relative to maximum height of headers of columns
        /// </summary>
        /// <value>Optional - scale factor for target table height - relative to maximum height of headers of columns</value>
        [DataMember(Name="TargetTableHeight_Relative", EmitDefaultValue=false)]
        public double? TargetTableHeightRelative { get; set; }

        /// <summary>
        /// Optional - scale factor for target row height - relative to height of column header
        /// </summary>
        /// <value>Optional - scale factor for target row height - relative to height of column header</value>
        [DataMember(Name="TargetRowHeight_Relative", EmitDefaultValue=false)]
        public double? TargetRowHeightRelative { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormTableDefinition {\n");
            sb.Append("  TableID: ").Append(TableID).Append("\n");
            sb.Append("  ColumnDefinitions: ").Append(ColumnDefinitions).Append("\n");
            sb.Append("  TargetTableHeightRelative: ").Append(TargetTableHeightRelative).Append("\n");
            sb.Append("  TargetRowHeightRelative: ").Append(TargetRowHeightRelative).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FormTableDefinition);
        }

        /// <summary>
        /// Returns true if FormTableDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of FormTableDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormTableDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableID == input.TableID ||
                    (this.TableID != null &&
                    this.TableID.Equals(input.TableID))
                ) && 
                (
                    this.ColumnDefinitions == input.ColumnDefinitions ||
                    this.ColumnDefinitions != null &&
                    this.ColumnDefinitions.SequenceEqual(input.ColumnDefinitions)
                ) && 
                (
                    this.TargetTableHeightRelative == input.TargetTableHeightRelative ||
                    (this.TargetTableHeightRelative != null &&
                    this.TargetTableHeightRelative.Equals(input.TargetTableHeightRelative))
                ) && 
                (
                    this.TargetRowHeightRelative == input.TargetRowHeightRelative ||
                    (this.TargetRowHeightRelative != null &&
                    this.TargetRowHeightRelative.Equals(input.TargetRowHeightRelative))
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
                int hashCode = 41;
                if (this.TableID != null)
                    hashCode = hashCode * 59 + this.TableID.GetHashCode();
                if (this.ColumnDefinitions != null)
                    hashCode = hashCode * 59 + this.ColumnDefinitions.GetHashCode();
                if (this.TargetTableHeightRelative != null)
                    hashCode = hashCode * 59 + this.TargetTableHeightRelative.GetHashCode();
                if (this.TargetRowHeightRelative != null)
                    hashCode = hashCode * 59 + this.TargetRowHeightRelative.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
