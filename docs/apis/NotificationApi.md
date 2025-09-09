# Moira.ApiClient.Api.NotificationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAllNotifications**](NotificationApi.md#deleteallnotifications) | **DELETE** /notification/all | Delete all notifications |
| [**DeleteNotification**](NotificationApi.md#deletenotification) | **DELETE** /notification | Delete a notification by id |
| [**DeleteNotificationsFiltered**](NotificationApi.md#deletenotificationsfiltered) | **DELETE** /notification/filtered | Delete notifications filtered by tags and timestamps |
| [**GetNotifications**](NotificationApi.md#getnotifications) | **GET** /notification | Gets a paginated list of notifications, all notifications are fetched if end &#x3D; -1 and start &#x3D; 0 |

<a id="deleteallnotifications"></a>
# **DeleteAllNotifications**
> DtoNotificationsList DeleteAllNotifications ()

Delete all notifications


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoNotificationsList**](DtoNotificationsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Notification have been deleted |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletenotification"></a>
# **DeleteNotification**
> DtoNotificationDeleteResponse DeleteNotification (string id)

Delete a notification by id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of deleted notification | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoNotificationDeleteResponse**](DtoNotificationDeleteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Notification have been deleted |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletenotificationsfiltered"></a>
# **DeleteNotificationsFiltered**
> DtoNotificationsList DeleteNotificationsFiltered (int start, int end, List<string> ignoredTags = null, List<string> clusterKeys = null)

Delete notifications filtered by tags and timestamps


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int** | Time range start |  |
| **end** | **int** | Time range end |  |
| **ignoredTags** | [**List&lt;string&gt;**](string.md) | Notifications for triggers with any of these tags will not be deleted | [optional]  |
| **clusterKeys** | [**List&lt;string&gt;**](string.md) | List of cluster keys for which notifications should be deleted. Defaults to all if no clusters are specified | [optional]  |

### Return type

[**DtoNotificationsList**](DtoNotificationsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Notification have been deleted |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getnotifications"></a>
# **GetNotifications**
> DtoNotificationsList GetNotifications (int start = null, int end = null)

Gets a paginated list of notifications, all notifications are fetched if end = -1 and start = 0


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int** | Default Value: 0 | [optional] [default to 0] |
| **end** | **int** | Default Value: -1 | [optional] [default to -1] |

### Return type

[**DtoNotificationsList**](DtoNotificationsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Notifications fetched successfully |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

