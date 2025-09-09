# Moira.ApiClient.Api.TagApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTags**](TagApi.md#createtags) | **POST** /tag | Create new tags |
| [**GetAllSystemTags**](TagApi.md#getallsystemtags) | **GET** /system-tag | Get all system tags |
| [**GetAllTags**](TagApi.md#getalltags) | **GET** /tag | Get all tags |
| [**GetAllTagsAndSubscriptions**](TagApi.md#getalltagsandsubscriptions) | **GET** /tag/stats | Get all tags and their subscriptions |
| [**RemoveTag**](TagApi.md#removetag) | **DELETE** /tag/{tag} | Remove a tag |

<a id="createtags"></a>
# **CreateTags**
> string CreateTags (DtoTagsData dtoTagsData)

Create new tags


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTagsData** | [**DtoTagsData**](DtoTagsData.md) | Tags data |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Create tags successfully |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallsystemtags"></a>
# **GetAllSystemTags**
> DtoTagsData GetAllSystemTags ()

Get all system tags


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoTagsData**](DtoTagsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tags fetched successfully |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getalltags"></a>
# **GetAllTags**
> DtoTagsData GetAllTags ()

Get all tags


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoTagsData**](DtoTagsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tags fetched successfully |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getalltagsandsubscriptions"></a>
# **GetAllTagsAndSubscriptions**
> DtoTagsStatistics GetAllTagsAndSubscriptions ()

Get all tags and their subscriptions


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoTagsStatistics**](DtoTagsStatistics.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removetag"></a>
# **RemoveTag**
> DtoMessageResponse RemoveTag (string tag)

Remove a tag


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | Name of the tag to remove |  |

### Return type

[**DtoMessageResponse**](DtoMessageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tag removed successfully |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

