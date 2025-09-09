# Moira.ApiClient.Api.HealthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetNotifierStateForSources**](HealthApi.md#getnotifierstateforsources) | **GET** /health/notifier | Get notifier states for sources |
| [**GetSystemSubscription**](HealthApi.md#getsystemsubscription) | **GET** /health/system-subscriptions | Get system subscriptions by system tags |
| [**SetNotifierState**](HealthApi.md#setnotifierstate) | **PUT** /health/notifier | Set notifier state |

<a id="getnotifierstateforsources"></a>
# **GetNotifierStateForSources**
> DtoNotifierStatesForSources GetNotifierStateForSources ()

Get notifier states for sources


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoNotifierStatesForSources**](DtoNotifierStatesForSources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Notifier state retrieved |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsystemsubscription"></a>
# **GetSystemSubscription**
> DtoSubscriptionList GetSystemSubscription ()

Get system subscriptions by system tags


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoSubscriptionList**](DtoSubscriptionList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscriptions fetched successfully |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="setnotifierstate"></a>
# **SetNotifierState**
> DtoNotifierState SetNotifierState ()

Set notifier state


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoNotifierState**](DtoNotifierState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Notifier state retrieved |  -  |
| **403** | Forbidden |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

