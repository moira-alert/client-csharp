# Moira.ApiClient.Api.TeamApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTeamUsers**](TeamApi.md#addteamusers) | **POST** /teams/{teamID}/users | Add users to a team |
| [**CreateTeam**](TeamApi.md#createteam) | **POST** /teams | Create a new team |
| [**DeleteTeam**](TeamApi.md#deleteteam) | **DELETE** /teams/{teamID} | Delete a team |
| [**DeleteTeamUser**](TeamApi.md#deleteteamuser) | **DELETE** /teams/{teamID}/users/{teamUserID} | Delete a user from a team |
| [**GetAllTeams**](TeamApi.md#getallteams) | **GET** /teams/all | Get all Moira teams |
| [**GetAllTeamsForUser**](TeamApi.md#getallteamsforuser) | **GET** /teams | Get all teams for user |
| [**GetTeam**](TeamApi.md#getteam) | **GET** /teams/{teamID} | Get a team by ID |
| [**GetTeamSettings**](TeamApi.md#getteamsettings) | **GET** /teams/{teamID}/settings | Get team settings |
| [**GetTeamUsers**](TeamApi.md#getteamusers) | **GET** /teams/{teamID}/users | Get users of a team |
| [**SetTeamUsers**](TeamApi.md#setteamusers) | **PUT** /teams/{teamID}/users | Set users of a team |
| [**UpdateTeam**](TeamApi.md#updateteam) | **PATCH** /teams/{teamID} | Update existing team |

<a id="addteamusers"></a>
# **AddTeamUsers**
> DtoTeamMembers AddTeamUsers (DtoTeamMembers dtoTeamMembers, string teamID)

Add users to a team


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTeamMembers** | [**DtoTeamMembers**](DtoTeamMembers.md) | Usernames to add to the team |  |
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTeamMembers**](DtoTeamMembers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team updated successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createteam"></a>
# **CreateTeam**
> DtoSaveTeamResponse CreateTeam (DtoTeamModel dtoTeamModel)

Create a new team


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTeamModel** | [**DtoTeamModel**](DtoTeamModel.md) | Team data |  |

### Return type

[**DtoSaveTeamResponse**](DtoSaveTeamResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team created successfully |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteteam"></a>
# **DeleteTeam**
> DtoSaveTeamResponse DeleteTeam (string teamID)

Delete a team


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoSaveTeamResponse**](DtoSaveTeamResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team has been successfully deleted |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteteamuser"></a>
# **DeleteTeamUser**
> DtoTeamMembers DeleteTeamUser (string teamID, string teamUserID)

Delete a user from a team


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **teamUserID** | **string** | User login in methods related to teams manipulation | [default to &quot;anonymous&quot;] |

### Return type

[**DtoTeamMembers**](DtoTeamMembers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team updated successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallteams"></a>
# **GetAllTeams**
> DtoTeamsList GetAllTeams (int size = null, int p = null, string searchText = null, string sort = null)

Get all Moira teams


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **size** | **int** | Number of items to be displayed on one page. if size &#x3D; -1 then all teams returned | [optional] [default to -1] |
| **p** | **int** | Defines the number of the displayed page. E.g, p&#x3D;2 would display the 2nd page | [optional] [default to 0] |
| **searchText** | **string** | Regular expression which will be applied to team id or team name than filtering teams | [optional] [default to &quot;.*&quot;] |
| **sort** | **string** | String to set sort order (by name). On empty - no order, asc - ascending, desc - descending | [optional] [default to &quot;asc&quot;] |

### Return type

[**DtoTeamsList**](DtoTeamsList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Teams fetched successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallteamsforuser"></a>
# **GetAllTeamsForUser**
> DtoUserTeams GetAllTeamsForUser ()

Get all teams for user


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoUserTeams**](DtoUserTeams.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Teams fetched successfully |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getteam"></a>
# **GetTeam**
> DtoTeamModel GetTeam (string teamID)

Get a team by ID


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTeamModel**](DtoTeamModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team updated successfully |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getteamsettings"></a>
# **GetTeamSettings**
> DtoTeamSettings GetTeamSettings (string teamID)

Get team settings


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTeamSettings**](DtoTeamSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team settings |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getteamusers"></a>
# **GetTeamUsers**
> DtoTeamMembers GetTeamUsers (string teamID)

Get users of a team


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTeamMembers**](DtoTeamMembers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Users fetched successfully |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="setteamusers"></a>
# **SetTeamUsers**
> DtoTeamMembers SetTeamUsers (DtoTeamMembers dtoTeamMembers, string teamID)

Set users of a team


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTeamMembers** | [**DtoTeamMembers**](DtoTeamMembers.md) | Usernames to set as team members |  |
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTeamMembers**](DtoTeamMembers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team updated successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateteam"></a>
# **UpdateTeam**
> DtoSaveTeamResponse UpdateTeam (DtoTeamModel dtoTeamModel, string teamID)

Update existing team


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTeamModel** | [**DtoTeamModel**](DtoTeamModel.md) | Updated team data |  |
| **teamID** | **string** | ID of the team | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoSaveTeamResponse**](DtoSaveTeamResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team updated successfully |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

