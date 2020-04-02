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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.OCR.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.OCR.Model
{
    /// <summary>
    /// The recognition result of one cell in one row in a table of a form
    /// </summary>
    [DataContract]
    public partial class TableCellResult :  IEquatable<TableCellResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableCellResult" /> class.
        /// </summary>
        /// <param name="columnID">The ID of the column.</param>
        /// <param name="cellValues">Result cell value(s) extracted.</param>
        public TableCellResult(string columnID = default(string), List<OcrPhotoTextElement> cellValues = default(List<OcrPhotoTextElement>))
        {
            this.ColumnID = columnID;
            this.CellValues = cellValues;
        }
        
        /// <summary>
        /// The ID of the column
        /// </summary>
        /// <value>The ID of the column</value>
        [DataMember(Name="ColumnID", EmitDefaultValue=false)]
        public string ColumnID { get; set; }

        /// <summary>
        /// Result cell value(s) extracted
        /// </summary>
        /// <value>Result cell value(s) extracted</value>
        [DataMember(Name="CellValues", EmitDefaultValue=false)]
        public List<OcrPhotoTextElement> CellValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableCellResult {\n");
            sb.Append("  ColumnID: ").Append(ColumnID).Append("\n");
            sb.Append("  CellValues: ").Append(CellValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TableCellResult);
        }

        /// <summary>
        /// Returns true if TableCellResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TableCellResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableCellResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnID == input.ColumnID ||
                    (this.ColumnID != null &&
                    this.ColumnID.Equals(input.ColumnID))
                ) && 
                (
                    this.CellValues == input.CellValues ||
                    this.CellValues != null &&
                    this.CellValues.SequenceEqual(input.CellValues)
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
                if (this.ColumnID != null)
                    hashCode = hashCode * 59 + this.ColumnID.GetHashCode();
                if (this.CellValues != null)
                    hashCode = hashCode * 59 + this.CellValues.GetHashCode();
                return hashCode;
            }
        }
    }

}
