# Cloudmersive.APIClient.NETCore.OCR.Api.ImageOcrApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImageOcrPost**](ImageOcrApi.md#imageocrpost) | **POST** /ocr/image/toText | Converts an uploaded image in common formats such as JPEG, PNG into text via Optical Character Recognition.


<a name="imageocrpost"></a>
# **ImageOcrPost**
> ImageToTextResponse ImageOcrPost (System.IO.Stream imageFile)

Converts an uploaded image in common formats such as JPEG, PNG into text via Optical Character Recognition.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class ImageOcrPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ImageOcrApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Converts an uploaded image in common formats such as JPEG, PNG into text via Optical Character Recognition.
                ImageToTextResponse result = apiInstance.ImageOcrPost(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageOcrApi.ImageOcrPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**ImageToTextResponse**](ImageToTextResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

