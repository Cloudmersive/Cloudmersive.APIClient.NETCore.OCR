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
    /// Definition of a form template; use a form template definition to recognize the fields in a form with Cloudmersive OCR
    /// </summary>
    [DataContract]
    public partial class FormDefinitionTemplate :  IEquatable<FormDefinitionTemplate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDefinitionTemplate" /> class.
        /// </summary>
        /// <param name="fieldDefinitions">Field definitions in the template; a field is comprised of a key/value pair.</param>
        /// <param name="tableDefinitions">Table definitions in the template; a table is comprised of columns and rows and exists in a 2-dimensional layout; a common example of a table would be an invoice.</param>
        public FormDefinitionTemplate(List<FormFieldDefinition> fieldDefinitions = default(List<FormFieldDefinition>), List<FormTableDefinition> tableDefinitions = default(List<FormTableDefinition>))
        {
            this.FieldDefinitions = fieldDefinitions;
            this.TableDefinitions = tableDefinitions;
        }
        
        /// <summary>
        /// Field definitions in the template; a field is comprised of a key/value pair
        /// </summary>
        /// <value>Field definitions in the template; a field is comprised of a key/value pair</value>
        [DataMember(Name="FieldDefinitions", EmitDefaultValue=false)]
        public List<FormFieldDefinition> FieldDefinitions { get; set; }

        /// <summary>
        /// Table definitions in the template; a table is comprised of columns and rows and exists in a 2-dimensional layout; a common example of a table would be an invoice
        /// </summary>
        /// <value>Table definitions in the template; a table is comprised of columns and rows and exists in a 2-dimensional layout; a common example of a table would be an invoice</value>
        [DataMember(Name="TableDefinitions", EmitDefaultValue=false)]
        public List<FormTableDefinition> TableDefinitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormDefinitionTemplate {\n");
            sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append("\n");
            sb.Append("  TableDefinitions: ").Append(TableDefinitions).Append("\n");
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
            return this.Equals(input as FormDefinitionTemplate);
        }

        /// <summary>
        /// Returns true if FormDefinitionTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of FormDefinitionTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormDefinitionTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldDefinitions == input.FieldDefinitions ||
                    this.FieldDefinitions != null &&
                    this.FieldDefinitions.SequenceEqual(input.FieldDefinitions)
                ) && 
                (
                    this.TableDefinitions == input.TableDefinitions ||
                    this.TableDefinitions != null &&
                    this.TableDefinitions.SequenceEqual(input.TableDefinitions)
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
                if (this.FieldDefinitions != null)
                    hashCode = hashCode * 59 + this.FieldDefinitions.GetHashCode();
                if (this.TableDefinitions != null)
                    hashCode = hashCode * 59 + this.TableDefinitions.GetHashCode();
                return hashCode;
            }
        }
    }

}
