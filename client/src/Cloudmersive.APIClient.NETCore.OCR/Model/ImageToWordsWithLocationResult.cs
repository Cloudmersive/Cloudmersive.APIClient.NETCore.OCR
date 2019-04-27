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
    /// Result of an image to words-with-location OCR operation
    /// </summary>
    [DataContract]
    public partial class ImageToWordsWithLocationResult :  IEquatable<ImageToWordsWithLocationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToWordsWithLocationResult" /> class.
        /// </summary>
        /// <param name="Successful">Successful.</param>
        /// <param name="Words">Word elements in the image.</param>
        public ImageToWordsWithLocationResult(bool? Successful = default(bool?), List<OcrWordElement> Words = default(List<OcrWordElement>))
        {
            this.Successful = Successful;
            this.Words = Words;
        }
        
        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Word elements in the image
        /// </summary>
        /// <value>Word elements in the image</value>
        [DataMember(Name="Words", EmitDefaultValue=false)]
        public List<OcrWordElement> Words { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageToWordsWithLocationResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Words: ").Append(Words).Append("\n");
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
            return this.Equals(input as ImageToWordsWithLocationResult);
        }

        /// <summary>
        /// Returns true if ImageToWordsWithLocationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageToWordsWithLocationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageToWordsWithLocationResult input)
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
                    this.Words == input.Words ||
                    this.Words != null &&
                    this.Words.SequenceEqual(input.Words)
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
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
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
