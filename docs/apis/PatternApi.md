# Moira.ApiClient.Api.PatternApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePattern**](PatternApi.md#deletepattern) | **DELETE** /pattern/{pattern} | Deletes a Moira pattern |
| [**GetAllPatterns**](PatternApi.md#getallpatterns) | **GET** /pattern | Get all patterns |

<a id="deletepattern"></a>
# **DeletePattern**
> Object DeletePattern (string pattern)

Deletes a Moira pattern


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pattern** | **string** | Trigger pattern to operate on | [default to &quot;DevOps.my_server.hdd.freespace_mbytes&quot;] |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pattern deleted successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallpatterns"></a>
# **GetAllPatterns**
> DtoPatternList GetAllPatterns ()

Get all patterns


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoPatternList**](DtoPatternList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Patterns fetched successfully |  -  |
| **403** | Forbidden |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

