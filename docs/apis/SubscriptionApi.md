# Moira.ApiClient.Api.SubscriptionApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSubscription**](SubscriptionApi.md#createsubscription) | **PUT** /subscription | Create a new subscription |
| [**GetSubscription**](SubscriptionApi.md#getsubscription) | **GET** /subscription/{subscriptionID} | Get subscription by id |
| [**GetUserSubscriptions**](SubscriptionApi.md#getusersubscriptions) | **GET** /subscription | Get all subscriptions |
| [**RemoveSubscription**](SubscriptionApi.md#removesubscription) | **DELETE** /subscription/{subscriptionID} | Delete a subscription |
| [**SendTestNotification**](SubscriptionApi.md#sendtestnotification) | **PUT** /subscription/{subscriptionID}/test | Send a test notification for a subscription |
| [**UpdateSubscription**](SubscriptionApi.md#updatesubscription) | **PUT** /subscription/{subscriptionID} | Update a subscription |

<a id="createsubscription"></a>
# **CreateSubscription**
> DtoSubscription CreateSubscription (DtoSubscription dtoSubscription)

Create a new subscription


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoSubscription** | [**DtoSubscription**](DtoSubscription.md) | Subscription data |  |

### Return type

[**DtoSubscription**](DtoSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription created successfully |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsubscription"></a>
# **GetSubscription**
> DtoSubscription GetSubscription (string subscriptionID)

Get subscription by id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionID** | **string** | ID of the subscription to get | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoSubscription**](DtoSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription fetched successfully |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusersubscriptions"></a>
# **GetUserSubscriptions**
> DtoSubscriptionList GetUserSubscriptions ()

Get all subscriptions


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

<a id="removesubscription"></a>
# **RemoveSubscription**
> Object RemoveSubscription (string subscriptionID)

Delete a subscription


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionID** | **string** | ID of the subscription to remove | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

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
| **200** | Subscription deleted |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtestnotification"></a>
# **SendTestNotification**
> Object SendTestNotification (string subscriptionID)

Send a test notification for a subscription


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionID** | **string** | ID of the subscription to send the test notification | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

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
| **200** | Test notification sent successfully |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatesubscription"></a>
# **UpdateSubscription**
> DtoSubscription UpdateSubscription (DtoSubscription dtoSubscription, string subscriptionID)

Update a subscription


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoSubscription** | [**DtoSubscription**](DtoSubscription.md) | Updated subscription data |  |
| **subscriptionID** | **string** | ID of the subscription to update | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoSubscription**](DtoSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription updated successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

