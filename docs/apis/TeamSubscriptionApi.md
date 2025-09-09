# Moira.ApiClient.Api.TeamSubscriptionApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewTeamSubscription**](TeamSubscriptionApi.md#createnewteamsubscription) | **POST** /teams/{teamID}/subscriptions | Create a new team subscription |

<a id="createnewteamsubscription"></a>
# **CreateNewTeamSubscription**
> DtoSubscription CreateNewTeamSubscription (DtoSubscription dtoSubscription, string teamID)

Create a new team subscription


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoSubscription** | [**DtoSubscription**](DtoSubscription.md) | Team subscription data |  |
| **teamID** | **string** | The ID of team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

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
| **200** | Team subscription created successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

