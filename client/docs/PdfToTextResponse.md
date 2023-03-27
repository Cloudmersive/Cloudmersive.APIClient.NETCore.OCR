# Cloudmersive.APIClient.NETCore.OCR.Model.PdfToTextResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if successful, false otherwise | [optional] 
**OcrPages** | [**List&lt;OcrPageResult&gt;**](OcrPageResult.md) | Page OCR results | [optional] 
**AsyncJobID** | **string** | When the job exceeds 25 pages, an Async Job ID is returned.  Use the CheckPdfOcrJobStatus API to check on the status of this job using the AsyncJobID and get the result when it finishes | [optional] 
**AsyncJobStatus** | **string** | Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

