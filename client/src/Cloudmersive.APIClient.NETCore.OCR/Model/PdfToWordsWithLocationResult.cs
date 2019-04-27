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
    /// Response from an OCR to words with location operation.  Includes the confience rating and converted text result, along with the locations of the words in the pages.
    /// </summary>
    [DataContract]
    public partial class PdfToWordsWithLocationResult :  IEquatable<PdfToWordsWithLocationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfToWordsWithLocationResult" /> class.
        /// </summary>
        /// <param name="Successful">Successful.</param>
        /// <param name="OcrPages">OcrPages.</param>
        public PdfToWordsWithLocationResult(bool? Successful = default(bool?), List<OcrPageResultWithWordsWithLocation> OcrPages = default(List<OcrPageResultWithWordsWithLocation>))
        {
            this.Successful = Successful;
            this.OcrPages = OcrPages;
        }
        
        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Gets or Sets OcrPages
        /// </summary>
        [DataMember(Name="OcrPages", EmitDefaultValue=false)]
        public List<OcrPageResultWithWordsWithLocation> OcrPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfToWordsWithLocationResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  OcrPages: ").Append(OcrPages).Append("\n");
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
            return this.Equals(input as PdfToWordsWithLocationResult);
        }

        /// <summary>
        /// Returns true if PdfToWordsWithLocationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfToWordsWithLocationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfToWordsWithLocationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.OcrPages == input.OcrPages ||
                    this.OcrPages != null &&
                    this.OcrPages.SequenceEqual(input.OcrPages)
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.OcrPages != null)
                    hashCode = hashCode * 59 + this.OcrPages.GetHashCode();
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
