# Moira.ApiClient.Api.UserApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetUserName**](UserApi.md#getusername) | **GET** /user | Gets the username of the authenticated user if it is available |
| [**GetUserSettings**](UserApi.md#getusersettings) | **GET** /user/settings | Get the user&#39;s contacts and subscriptions |

<a id="getusername"></a>
# **GetUserName**
> DtoUser GetUserName ()

Gets the username of the authenticated user if it is available


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoUser**](DtoUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User name fetched successfully |  -  |
| **422** | Render error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusersettings"></a>
# **GetUserSettings**
> DtoUserSettings GetUserSettings ()

Get the user's contacts and subscriptions


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoUserSettings**](DtoUserSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Settings fetched successfully |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

