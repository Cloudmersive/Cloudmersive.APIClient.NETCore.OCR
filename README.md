# Cloudmersive.APIClient.NETCore.OCR - the C# library for the ocrapi

The powerful Optical Character Recognition (OCR) APIs let you convert scanned images of pages into recognized text.

This C# SDK is for the [Cloudmersive OCR API](https://www.cloudmersive.com/ocr-api):

- API version: v1
- SDK version: 3.0.1
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new ImageOcrApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.
            var language = language_example;  // string | Optional, language of the input document, default is English (ENG).  Possible values are ENG (English), ARA (Arabic), ZHO (Chinese - Simplified), ZHO-HANT (Chinese - Traditional), ASM (Assamese), AFR (Afrikaans), AMH (Amharic), AZE (Azerbaijani), AZE-CYRL (Azerbaijani - Cyrillic), BEL (Belarusian), BEN (Bengali), BOD (Tibetan), BOS (Bosnian), BUL (Bulgarian), CAT (Catalan; Valencian), CEB (Cebuano), CES (Czech), CHR (Cherokee), CYM (Welsh), DAN (Danish), DEU (German), DZO (Dzongkha), ELL (Greek), ENM (Archaic/Middle English), EPO (Esperanto), EST (Estonian), EUS (Basque), FAS (Persian), FIN (Finnish), FRA (French), FRK (Frankish), FRM (Middle-French), GLE (Irish), GLG (Galician), GRC (Ancient Greek), HAT (Hatian), HEB (Hebrew), HIN (Hindi), HRV (Croatian), HUN (Hungarian), IKU (Inuktitut), IND (Indonesian), ISL (Icelandic), ITA (Italian), ITA-OLD (Old - Italian), JAV (Javanese), JPN (Japanese), KAN (Kannada), KAT (Georgian), KAT-OLD (Old-Georgian), KAZ (Kazakh), KHM (Central Khmer), KIR (Kirghiz), KOR (Korean), KUR (Kurdish), LAO (Lao), LAT (Latin), LAV (Latvian), LIT (Lithuanian), MAL (Malayalam), MAR (Marathi), MKD (Macedonian), MLT (Maltese), MSA (Malay), MYA (Burmese), NEP (Nepali), NLD (Dutch), NOR (Norwegian), ORI (Oriya), PAN (Panjabi), POL (Polish), POR (Portuguese), PUS (Pushto), RON (Romanian), RUS (Russian), SAN (Sanskrit), SIN (Sinhala), SLK (Slovak), SLV (Slovenian), SPA (Spanish), SPA-OLD (Old Spanish), SQI (Albanian), SRP (Serbian), SRP-LAT (Latin Serbian), SWA (Swahili), SWE (Swedish), SYR (Syriac), TAM (Tamil), TEL (Telugu), TGK (Tajik), TGL (Tagalog), THA (Thai), TIR (Tigrinya), TUR (Turkish), UIG (Uighur), UKR (Ukrainian), URD (Urdu), UZB (Uzbek), UZB-CYR (Cyrillic Uzbek), VIE (Vietnamese), YID (Yiddish) (optional) 
            var preprocessing = preprocessing_example;  // string | Optional, preprocessing mode, default is 'Auto'.  Possible values are None (no preprocessing of the image), and Auto (automatic image enhancement of the image before OCR is applied; this is recommended). (optional) 

            try
            {
                // Convert a scanned image into words with location
                ImageToLinesWithLocationResult result = apiInstance.ImageOcrImageLinesWithLocation(imageFile, language, preprocessing);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageOcrApi.ImageOcrImageLinesWithLocation: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ImageOcrApi* | [**ImageOcrImageLinesWithLocation**](docs/ImageOcrApi.md#imageocrimagelineswithlocation) | **POST** /ocr/image/to/lines-with-location | Convert a scanned image into words with location
*ImageOcrApi* | [**ImageOcrImageWordsWithLocation**](docs/ImageOcrApi.md#imageocrimagewordswithlocation) | **POST** /ocr/image/to/words-with-location | Convert a scanned image into words with location
*ImageOcrApi* | [**ImageOcrPhotoRecognizeBusinessCard**](docs/ImageOcrApi.md#imageocrphotorecognizebusinesscard) | **POST** /ocr/photo/recognize/business-card | Recognize a photo of a business card, extract key business information
*ImageOcrApi* | [**ImageOcrPhotoRecognizeForm**](docs/ImageOcrApi.md#imageocrphotorecognizeform) | **POST** /ocr/photo/recognize/form | Recognize a photo of a form, extract key fields and business information
*ImageOcrApi* | [**ImageOcrPhotoRecognizeFormAdvanced**](docs/ImageOcrApi.md#imageocrphotorecognizeformadvanced) | **POST** /ocr/photo/recognize/form/advanced | Recognize a photo of a form, extract key fields using stored templates
*ImageOcrApi* | [**ImageOcrPhotoRecognizeReceipt**](docs/ImageOcrApi.md#imageocrphotorecognizereceipt) | **POST** /ocr/photo/recognize/receipt | Recognize a photo of a receipt, extract key business information
*ImageOcrApi* | [**ImageOcrPhotoToText**](docs/ImageOcrApi.md#imageocrphotototext) | **POST** /ocr/photo/toText | Convert a photo of a document into text
*ImageOcrApi* | [**ImageOcrPhotoWordsWithLocation**](docs/ImageOcrApi.md#imageocrphotowordswithlocation) | **POST** /ocr/photo/to/words-with-location | Convert a photo of a document or receipt into words with location
*ImageOcrApi* | [**ImageOcrPost**](docs/ImageOcrApi.md#imageocrpost) | **POST** /ocr/image/toText | Convert a scanned image into text
*PdfOcrApi* | [**PdfOcrGetAsyncJobStatus**](docs/PdfOcrApi.md#pdfocrgetasyncjobstatus) | **GET** /ocr/pdf/get-job-status | Returns the result of the Async Job - possible states can be STARTED or COMPLETED
*PdfOcrApi* | [**PdfOcrPdfToLinesWithLocation**](docs/PdfOcrApi.md#pdfocrpdftolineswithlocation) | **POST** /ocr/pdf/to/lines-with-location | Convert a PDF into text lines with location
*PdfOcrApi* | [**PdfOcrPdfToWordsWithLocation**](docs/PdfOcrApi.md#pdfocrpdftowordswithlocation) | **POST** /ocr/pdf/to/words-with-location | Convert a PDF into words with location
*PdfOcrApi* | [**PdfOcrPost**](docs/PdfOcrApi.md#pdfocrpost) | **POST** /ocr/pdf/toText | Converts an uploaded PDF file into text via Optical Character Recognition.
*PreprocessingApi* | [**PreprocessingBinarize**](docs/PreprocessingApi.md#preprocessingbinarize) | **POST** /ocr/preprocessing/image/binarize | Convert an image of text into a binarized (light and dark) view
*PreprocessingApi* | [**PreprocessingBinarizeAdvanced**](docs/PreprocessingApi.md#preprocessingbinarizeadvanced) | **POST** /ocr/preprocessing/image/binarize/advanced | Convert an image of text into a binary (light and dark) view with ML
*PreprocessingApi* | [**PreprocessingGetPageAngle**](docs/PreprocessingApi.md#preprocessinggetpageangle) | **POST** /ocr/preprocessing/image/get-page-angle | Get the angle of the page / document / receipt
*PreprocessingApi* | [**PreprocessingUnrotate**](docs/PreprocessingApi.md#preprocessingunrotate) | **POST** /ocr/preprocessing/image/unrotate | Detect and unrotate a document image
*PreprocessingApi* | [**PreprocessingUnrotateAdvanced**](docs/PreprocessingApi.md#preprocessingunrotateadvanced) | **POST** /ocr/preprocessing/image/unrotate/advanced | Detect and unrotate a document image (advanced)
*PreprocessingApi* | [**PreprocessingUnskew**](docs/PreprocessingApi.md#preprocessingunskew) | **POST** /ocr/preprocessing/image/unskew | Detect and unskew a photo of a document
*ReceiptsApi* | [**ReceiptsPhotoToCSV**](docs/ReceiptsApi.md#receiptsphototocsv) | **POST** /ocr/receipts/photo/to/csv | Convert a photo of a receipt into a CSV file containing structured information from the receipt


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BusinessCardRecognitionResult](docs/BusinessCardRecognitionResult.md)
 - [Model.FieldResult](docs/FieldResult.md)
 - [Model.FormDefinitionTemplate](docs/FormDefinitionTemplate.md)
 - [Model.FormFieldDefinition](docs/FormFieldDefinition.md)
 - [Model.FormRecognitionResult](docs/FormRecognitionResult.md)
 - [Model.FormTableColumnDefinition](docs/FormTableColumnDefinition.md)
 - [Model.FormTableDefinition](docs/FormTableDefinition.md)
 - [Model.GetPageAngleResult](docs/GetPageAngleResult.md)
 - [Model.ImageToLinesWithLocationResult](docs/ImageToLinesWithLocationResult.md)
 - [Model.ImageToTextResponse](docs/ImageToTextResponse.md)
 - [Model.ImageToWordsWithLocationResult](docs/ImageToWordsWithLocationResult.md)
 - [Model.OcrLineElement](docs/OcrLineElement.md)
 - [Model.OcrPageResult](docs/OcrPageResult.md)
 - [Model.OcrPageResultWithLinesWithLocation](docs/OcrPageResultWithLinesWithLocation.md)
 - [Model.OcrPageResultWithWordsWithLocation](docs/OcrPageResultWithWordsWithLocation.md)
 - [Model.OcrPhotoTextElement](docs/OcrPhotoTextElement.md)
 - [Model.OcrWordElement](docs/OcrWordElement.md)
 - [Model.PdfToLinesWithLocationResult](docs/PdfToLinesWithLocationResult.md)
 - [Model.PdfToTextResponse](docs/PdfToTextResponse.md)
 - [Model.PdfToWordsWithLocationResult](docs/PdfToWordsWithLocationResult.md)
 - [Model.PhotoToWordsWithLocationResult](docs/PhotoToWordsWithLocationResult.md)
 - [Model.Point](docs/Point.md)
 - [Model.ReceiptLineItem](docs/ReceiptLineItem.md)
 - [Model.ReceiptRecognitionResult](docs/ReceiptRecognitionResult.md)
 - [Model.TableCellResult](docs/TableCellResult.md)
 - [Model.TableResult](docs/TableResult.md)
 - [Model.TableRowResult](docs/TableRowResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

