# Moira.ApiClient.Api.EventApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAllEvents**](EventApi.md#deleteallevents) | **DELETE** /event/all | Deletes all notification events |
| [**GetEventsList**](EventApi.md#geteventslist) | **GET** /event/{triggerID} | Gets all trigger events for current page and their count |

<a id="deleteallevents"></a>
# **DeleteAllEvents**
> Object DeleteAllEvents ()

Deletes all notification events


### Parameters
This endpoint does not need any parameter.
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
| **200** | Events removed successfully |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="geteventslist"></a>
# **GetEventsList**
> DtoEventsList GetEventsList (string triggerID, int size = null, int p = null, string from = null, string to = null, string metric = null, List<string> states = null)

Gets all trigger events for current page and their count


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | The ID of updated trigger | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **size** | **int** | Number of items to be displayed on one page. if size &#x3D; -1 then all events returned | [optional] [default to 100] |
| **p** | **int** | Defines the number of the displayed page. E.g, p&#x3D;2 would display the 2nd page | [optional] [default to 0] |
| **from** | **string** | Start time of the time range | [optional] [default to &quot;-3hours&quot;] |
| **to** | **string** | End time of the time range | [optional] [default to &quot;now&quot;] |
| **metric** | **string** | Regular expression that will be used to filter events | [optional] [default to &quot;.*&quot;] |
| **states** | [**List&lt;string&gt;**](string.md) | String of &#39;,&#39; separated state names. If empty then all states will be used. | [optional]  |

### Return type

[**DtoEventsList**](DtoEventsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Events fetched successfully |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

