# Cloudmersive.APIClient.NETCore.OCR.Model.ReceiptRecognitionResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation was successful, false otherwise | [optional] 
**Timestamp** | **DateTime?** | The date and time printed on the receipt (if included on the receipt) | [optional] 
**BusinessName** | **string** | The name of the business printed on the receipt (if included on the receipt) | [optional] 
**BusinessWebsite** | **string** | The website URL of the business printed on the receipt (if included on the receipt) | [optional] 
**AddressString** | **string** | The address of the business printed on the receipt (if included on the receipt) | [optional] 
**PhoneNumber** | **string** | The phone number printed on the receipt (if included on the receipt) | [optional] 
**ReceiptItems** | [**List&lt;ReceiptLineItem&gt;**](ReceiptLineItem.md) | The individual line items comprising the order; does not include total (see ReceiptTotal) | [optional] 
**ReceiptTotal** | **double?** | The total monetary value of the receipt (if included on the receipt) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

