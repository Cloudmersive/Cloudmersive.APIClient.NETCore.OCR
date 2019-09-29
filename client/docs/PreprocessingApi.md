# Cloudmersive.APIClient.NETCore.OCR.Api.PreprocessingApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PreprocessingBinarize**](PreprocessingApi.md#preprocessingbinarize) | **POST** /ocr/preprocessing/image/binarize | Convert an image of text into a binarized (light and dark) view
[**PreprocessingBinarizeAdvanced**](PreprocessingApi.md#preprocessingbinarizeadvanced) | **POST** /ocr/preprocessing/image/binarize/advanced | Convert an image of text into a binary (light and dark) view with ML
[**PreprocessingGetPageAngle**](PreprocessingApi.md#preprocessinggetpageangle) | **POST** /ocr/preprocessing/image/get-page-angle | Get the angle of the page / document / receipt
[**PreprocessingUnrotate**](PreprocessingApi.md#preprocessingunrotate) | **POST** /ocr/preprocessing/image/unrotate | Detect and unrotate a document image
[**PreprocessingUnrotateAdvanced**](PreprocessingApi.md#preprocessingunrotateadvanced) | **POST** /ocr/preprocessing/image/unrotate/advanced | Detect and unrotate a document image (advanced)
[**PreprocessingUnskew**](PreprocessingApi.md#preprocessingunskew) | **POST** /ocr/preprocessing/image/unskew | Detect and unskew a photo of a document


<a name="preprocessingbinarize"></a>
# **PreprocessingBinarize**
> byte[] PreprocessingBinarize (System.IO.Stream imageFile)

Convert an image of text into a binarized (light and dark) view

Perform an adaptive binarization algorithm on the input image to prepare it for further OCR operations.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class PreprocessingBinarizeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PreprocessingApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Convert an image of text into a binarized (light and dark) view
                byte[] result = apiInstance.PreprocessingBinarize(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreprocessingApi.PreprocessingBinarize: " + e.Message );
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

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="preprocessingbinarizeadvanced"></a>
# **PreprocessingBinarizeAdvanced**
> byte[] PreprocessingBinarizeAdvanced (System.IO.Stream imageFile)

Convert an image of text into a binary (light and dark) view with ML

Perform an advanced adaptive, Deep Learning-based binarization algorithm on the input image to prepare it for further OCR operations.  Provides enhanced accuracy than adaptive binarization.  Image will be upsampled to 300 DPI if it has a DPI below 300.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class PreprocessingBinarizeAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PreprocessingApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Convert an image of text into a binary (light and dark) view with ML
                byte[] result = apiInstance.PreprocessingBinarizeAdvanced(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreprocessingApi.PreprocessingBinarizeAdvanced: " + e.Message );
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

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="preprocessinggetpageangle"></a>
# **PreprocessingGetPageAngle**
> GetPageAngleResult PreprocessingGetPageAngle (System.IO.Stream imageFile)

Get the angle of the page / document / receipt

Analyzes a photo or image of a document and identifies the rotation angle of the page.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class PreprocessingGetPageAngleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PreprocessingApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Get the angle of the page / document / receipt
                GetPageAngleResult result = apiInstance.PreprocessingGetPageAngle(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreprocessingApi.PreprocessingGetPageAngle: " + e.Message );
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

[**GetPageAngleResult**](GetPageAngleResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="preprocessingunrotate"></a>
# **PreprocessingUnrotate**
> byte[] PreprocessingUnrotate (System.IO.Stream imageFile)

Detect and unrotate a document image

Detect and unrotate an image of a document (e.g. that was scanned at an angle).  Great for document scanning applications; once unskewed, this image is perfect for converting to PDF using the Convert API or optical character recognition using the OCR API.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class PreprocessingUnrotateExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PreprocessingApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect and unrotate a document image
                byte[] result = apiInstance.PreprocessingUnrotate(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreprocessingApi.PreprocessingUnrotate: " + e.Message );
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

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="preprocessingunrotateadvanced"></a>
# **PreprocessingUnrotateAdvanced**
> byte[] PreprocessingUnrotateAdvanced (System.IO.Stream imageFile)

Detect and unrotate a document image (advanced)

Detect and unrotate an image of a document (e.g. that was scanned at an angle) using deep learning.  Great for document scanning applications; once unskewed, this image is perfect for converting to PDF using the Convert API or optical character recognition using the OCR API.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class PreprocessingUnrotateAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PreprocessingApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect and unrotate a document image (advanced)
                byte[] result = apiInstance.PreprocessingUnrotateAdvanced(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreprocessingApi.PreprocessingUnrotateAdvanced: " + e.Message );
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

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="preprocessingunskew"></a>
# **PreprocessingUnskew**
> byte[] PreprocessingUnskew (System.IO.Stream imageFile)

Detect and unskew a photo of a document

Detect and unskew a photo of a document (e.g. taken on a cell phone) into a perfectly square image.  Great for document scanning applications; once unskewed, this image is perfect for converting to PDF using the Convert API or optical character recognition using the OCR API.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.OCR.Api;
using Cloudmersive.APIClient.NETCore.OCR.Client;
using Cloudmersive.APIClient.NETCore.OCR.Model;

namespace Example
{
    public class PreprocessingUnskewExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PreprocessingApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform OCR on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Detect and unskew a photo of a document
                byte[] result = apiInstance.PreprocessingUnskew(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreprocessingApi.PreprocessingUnskew: " + e.Message );
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

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

