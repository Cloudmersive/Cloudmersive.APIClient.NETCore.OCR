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
    /// Result of recognizing a business card, to extract the key information from the business card
    /// </summary>
    [DataContract]
    public partial class BusinessCardRecognitionResult :  IEquatable<BusinessCardRecognitionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessCardRecognitionResult" /> class.
        /// </summary>
        /// <param name="Successful">True if the operation was successful, false otherwise.</param>
        /// <param name="PersonName">The name of the person printed on the business card (if included on the business card).</param>
        /// <param name="PersonTitle">The title of the person printed on the business card (if included on the business card).</param>
        /// <param name="BusinessName">The name of the business printed on the business card (if included on the business card).</param>
        /// <param name="AddressString">The address printed on the business card (if included on the business card).</param>
        /// <param name="PhoneNumber">The phone number printed on the business card (if included on the business card).</param>
        /// <param name="EmailAddress">The email address printed on the business card (if included on the business card).</param>
        /// <param name="Timestamp">The date and time printed on the business card (if included on the business card).</param>
        public BusinessCardRecognitionResult(bool? Successful = default(bool?), string PersonName = default(string), string PersonTitle = default(string), string BusinessName = default(string), string AddressString = default(string), string PhoneNumber = default(string), string EmailAddress = default(string), DateTime? Timestamp = default(DateTime?))
        {
            this.Successful = Successful;
            this.PersonName = PersonName;
            this.PersonTitle = PersonTitle;
            this.BusinessName = BusinessName;
            this.AddressString = AddressString;
            this.PhoneNumber = PhoneNumber;
            this.EmailAddress = EmailAddress;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// The name of the person printed on the business card (if included on the business card)
        /// </summary>
        /// <value>The name of the person printed on the business card (if included on the business card)</value>
        [DataMember(Name="PersonName", EmitDefaultValue=false)]
        public string PersonName { get; set; }

        /// <summary>
        /// The title of the person printed on the business card (if included on the business card)
        /// </summary>
        /// <value>The title of the person printed on the business card (if included on the business card)</value>
        [DataMember(Name="PersonTitle", EmitDefaultValue=false)]
        public string PersonTitle { get; set; }

        /// <summary>
        /// The name of the business printed on the business card (if included on the business card)
        /// </summary>
        /// <value>The name of the business printed on the business card (if included on the business card)</value>
        [DataMember(Name="BusinessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// The address printed on the business card (if included on the business card)
        /// </summary>
        /// <value>The address printed on the business card (if included on the business card)</value>
        [DataMember(Name="AddressString", EmitDefaultValue=false)]
        public string AddressString { get; set; }

        /// <summary>
        /// The phone number printed on the business card (if included on the business card)
        /// </summary>
        /// <value>The phone number printed on the business card (if included on the business card)</value>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The email address printed on the business card (if included on the business card)
        /// </summary>
        /// <value>The email address printed on the business card (if included on the business card)</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The date and time printed on the business card (if included on the business card)
        /// </summary>
        /// <value>The date and time printed on the business card (if included on the business card)</value>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessCardRecognitionResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  PersonName: ").Append(PersonName).Append("\n");
            sb.Append("  PersonTitle: ").Append(PersonTitle).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  AddressString: ").Append(AddressString).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as BusinessCardRecognitionResult);
        }

        /// <summary>
        /// Returns true if BusinessCardRecognitionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessCardRecognitionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessCardRecognitionResult input)
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
                    this.PersonName == input.PersonName ||
                    (this.PersonName != null &&
                    this.PersonName.Equals(input.PersonName))
                ) && 
                (
                    this.PersonTitle == input.PersonTitle ||
                    (this.PersonTitle != null &&
                    this.PersonTitle.Equals(input.PersonTitle))
                ) && 
                (
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.AddressString == input.AddressString ||
                    (this.AddressString != null &&
                    this.AddressString.Equals(input.AddressString))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.PersonName != null)
                    hashCode = hashCode * 59 + this.PersonName.GetHashCode();
                if (this.PersonTitle != null)
                    hashCode = hashCode * 59 + this.PersonTitle.GetHashCode();
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.AddressString != null)
                    hashCode = hashCode * 59 + this.AddressString.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
