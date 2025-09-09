# Moira.ApiClient.Api.TriggerApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTrigger**](TriggerApi.md#createtrigger) | **PUT** /trigger | Create a new trigger |
| [**DeletePager**](TriggerApi.md#deletepager) | **DELETE** /trigger/search/pager | Delete triggers pager |
| [**DeleteTriggerMetric**](TriggerApi.md#deletetriggermetric) | **DELETE** /trigger/{triggerID}/metrics | Delete metric from last check and all trigger pattern metrics |
| [**DeleteTriggerNodataMetrics**](TriggerApi.md#deletetriggernodatametrics) | **DELETE** /trigger/{triggerID}/metrics/nodata | Delete all metrics from last data which are in NODATA state. It also deletes all trigger patterns of those metrics |
| [**DeleteTriggerThrottling**](TriggerApi.md#deletetriggerthrottling) | **DELETE** /trigger/{triggerID}/throttling | Deletes throttling for a trigger |
| [**GetAllTriggers**](TriggerApi.md#getalltriggers) | **GET** /trigger | Get all triggers |
| [**GetTrigger**](TriggerApi.md#gettrigger) | **GET** /trigger/{triggerID} | Get an existing trigger |
| [**GetTriggerDump**](TriggerApi.md#gettriggerdump) | **GET** /trigger/{triggerID}/dump | Get trigger dump |
| [**GetTriggerMetrics**](TriggerApi.md#gettriggermetrics) | **GET** /trigger/{triggerID}/metrics | Get metrics associated with certain trigger |
| [**GetTriggerState**](TriggerApi.md#gettriggerstate) | **GET** /trigger/{triggerID}/state | Get the trigger state as at last check |
| [**GetTriggerThrottling**](TriggerApi.md#gettriggerthrottling) | **GET** /trigger/{triggerID}/throttling | Get a trigger with its throttling i.e its next allowed message time |
| [**GetTriggersNoisiness**](TriggerApi.md#gettriggersnoisiness) | **GET** /trigger/noisiness | Get triggers noisiness |
| [**GetUnusedTriggers**](TriggerApi.md#getunusedtriggers) | **GET** /trigger/unused | Get unused triggers |
| [**RemoveTrigger**](TriggerApi.md#removetrigger) | **DELETE** /trigger/{triggerID} | Remove trigger |
| [**RenderTriggerMetrics**](TriggerApi.md#rendertriggermetrics) | **GET** /trigger/{triggerID}/render | Render trigger metrics plot |
| [**SearchTriggers**](TriggerApi.md#searchtriggers) | **GET** /trigger/search | Search triggers. Replaces the deprecated &#x60;page&#x60; path |
| [**SetTriggerMaintenance**](TriggerApi.md#settriggermaintenance) | **PUT** /trigger/{triggerID}/setMaintenance | Set metrics and the trigger itself to maintenance mode |
| [**TriggerCheck**](TriggerApi.md#triggercheck) | **PUT** /trigger/check | Validates trigger target |
| [**UpdateTrigger**](TriggerApi.md#updatetrigger) | **PUT** /trigger/{triggerID} | Update existing trigger |

<a id="createtrigger"></a>
# **CreateTrigger**
> DtoSaveTriggerResponse CreateTrigger (DtoTrigger dtoTrigger, bool validate = null)

Create a new trigger


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTrigger** | [**DtoTrigger**](DtoTrigger.md) | Trigger data |  |
| **validate** | **bool** | For validating targets | [optional]  |

### Return type

[**DtoSaveTriggerResponse**](DtoSaveTriggerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger created successfully |  -  |
| **400** | Bad request from client. Could be api.ErrorInvalidRequestExample or dto.SaveTriggerResponse |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |
| **503** | Remote server unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletepager"></a>
# **DeletePager**
> DtoTriggersSearchResultDeleteResponse DeletePager (string pagerID = null)

Delete triggers pager


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pagerID** | **string** | Pager ID | [optional] [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTriggersSearchResultDeleteResponse**](DtoTriggersSearchResultDeleteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully deleted pager |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetriggermetric"></a>
# **DeleteTriggerMetric**
> Object DeleteTriggerMetric (string triggerID, string name = null)

Delete metric from last check and all trigger pattern metrics


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **name** | **string** | Name of the target metric | [optional] [default to &quot;DevOps.my_server.hdd.freespace_mbytes&quot;] |

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
| **200** | Trigger metric deleted successfully |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetriggernodatametrics"></a>
# **DeleteTriggerNodataMetrics**
> Object DeleteTriggerNodataMetrics (string triggerID)

Delete all metrics from last data which are in NODATA state. It also deletes all trigger patterns of those metrics


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

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
| **200** | Trigger nodata metrics deleted successfully |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetriggerthrottling"></a>
# **DeleteTriggerThrottling**
> void DeleteTriggerThrottling (string triggerID)

Deletes throttling for a trigger


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger throttling has been deleted |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getalltriggers"></a>
# **GetAllTriggers**
> DtoTriggersList GetAllTriggers ()

Get all triggers


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoTriggersList**](DtoTriggersList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fetched all triggers |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettrigger"></a>
# **GetTrigger**
> DtoTrigger GetTrigger (string triggerID, bool populated = null)

Get an existing trigger


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **populated** | **bool** | Populated | [optional] [default to false] |

### Return type

[**DtoTrigger**](DtoTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger data |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettriggerdump"></a>
# **GetTriggerDump**
> DtoTriggerDump GetTriggerDump (string triggerID)

Get trigger dump


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTriggerDump**](DtoTriggerDump.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger dump |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettriggermetrics"></a>
# **GetTriggerMetrics**
> Dictionary&lt;string, Dictionary&lt;string, List&lt;MoiraMetricValue&gt;&gt;&gt; GetTriggerMetrics (string triggerID, string from = null, string to = null)

Get metrics associated with certain trigger


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **from** | **string** | Start time for metrics retrieval | [optional] [default to &quot;-10minutes&quot;] |
| **to** | **string** | End time for metrics retrieval | [optional] [default to &quot;now&quot;] |

### Return type

**Dictionary<string, Dictionary<string, List<MoiraMetricValue>>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger metrics retrieved successfully |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettriggerstate"></a>
# **GetTriggerState**
> DtoTriggerCheck GetTriggerState (string triggerID)

Get the trigger state as at last check


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoTriggerCheck**](DtoTriggerCheck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger state fetched successful |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettriggerthrottling"></a>
# **GetTriggerThrottling**
> DtoThrottlingResponse GetTriggerThrottling (string triggerID)

Get a trigger with its throttling i.e its next allowed message time


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoThrottlingResponse**](DtoThrottlingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger throttle info retrieved |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettriggersnoisiness"></a>
# **GetTriggersNoisiness**
> DtoTriggerNoisinessList GetTriggersNoisiness (int size = null, int p = null, string from = null, string to = null, string sort = null)

Get triggers noisiness


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **size** | **int** | Number of items to be displayed on one page. if size &#x3D; -1 then all events returned | [optional] [default to 100] |
| **p** | **int** | Defines the number of the displayed page. E.g, p&#x3D;2 would display the 2nd page | [optional] [default to 0] |
| **from** | **string** | Start time of the time range | [optional] [default to &quot;-3hours&quot;] |
| **to** | **string** | End time of the time range | [optional] [default to &quot;now&quot;] |
| **sort** | **string** | String to set sort order (by events_count). On empty - no order, asc - ascending, desc - descending | [optional] [default to &quot;desc&quot;] |

### Return type

[**DtoTriggerNoisinessList**](DtoTriggerNoisinessList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get noisiness for triggers in range |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getunusedtriggers"></a>
# **GetUnusedTriggers**
> DtoTriggersList GetUnusedTriggers ()

Get unused triggers


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoTriggersList**](DtoTriggersList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fetched unused triggers |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removetrigger"></a>
# **RemoveTrigger**
> void RemoveTrigger (string triggerID)

Remove trigger


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully removed |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rendertriggermetrics"></a>
# **RenderTriggerMetrics**
> System.IO.Stream RenderTriggerMetrics (string triggerID, string target = null, string from = null, string to = null, string timezone = null, string theme = null, bool realtime = null)

Render trigger metrics plot


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **target** | **string** | Target metric name | [optional] [default to &quot;t1&quot;] |
| **from** | **string** | Start time for metrics retrieval | [optional] [default to &quot;-1hour&quot;] |
| **to** | **string** | End time for metrics retrieval | [optional] [default to &quot;now&quot;] |
| **timezone** | **string** | Timezone for rendering | [optional] [default to &quot;UTC&quot;] |
| **theme** | **string** | Plot theme | [optional] [default to &quot;light&quot;] |
| **realtime** | **bool** | Fetch real-time data | [optional] [default to false] |

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Rendered plot image successfully |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="searchtriggers"></a>
# **SearchTriggers**
> DtoTriggersList SearchTriggers (bool onlyProblems = null, string text = null, int p = null, int size = null, List<string> tags = null, bool createPager = null, string pagerID = null, string createdBy = null)

Search triggers. Replaces the deprecated `page` path

You can also add filtering by tags, for this purpose add query parameters tags[0]=test, tags[1]=test1 and so on For example, `/api/trigger/search?tags[0]=test&tags[1]=test1`


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **onlyProblems** | **bool** | Only include problems | [optional] [default to false] |
| **text** | **string** | Search text | [optional] [default to &quot;cpu&quot;] |
| **p** | **int** | Page number | [optional] [default to 0] |
| **size** | **int** | Page size | [optional] [default to 10] |
| **tags** | [**List&lt;string&gt;**](string.md) | Search tag | [optional]  |
| **createPager** | **bool** | Create pager | [optional] [default to false] |
| **pagerID** | **string** | Pager ID | [optional] [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **createdBy** | **string** | Created By | [optional] [default to &quot;moira.team&quot;] |

### Return type

[**DtoTriggersList**](DtoTriggersList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully fetched matching triggers |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="settriggermaintenance"></a>
# **SetTriggerMaintenance**
> Object SetTriggerMaintenance (DtoTriggerMaintenance dtoTriggerMaintenance, string triggerID)

Set metrics and the trigger itself to maintenance mode


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTriggerMaintenance** | [**DtoTriggerMaintenance**](DtoTriggerMaintenance.md) | Maintenance data |  |
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Trigger or metric have been scheduled for maintenance |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="triggercheck"></a>
# **TriggerCheck**
> DtoTriggerCheckResponse TriggerCheck (DtoTrigger dtoTrigger)

Validates trigger target


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTrigger** | [**DtoTrigger**](DtoTrigger.md) | Trigger data |  |

### Return type

[**DtoTriggerCheckResponse**](DtoTriggerCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Validation is done, see response body for validation result |  -  |
| **400** | Bad request from client |  -  |
| **500** | Internal server error |  -  |
| **503** | Remote server unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatetrigger"></a>
# **UpdateTrigger**
> DtoSaveTriggerResponse UpdateTrigger (DtoTrigger dtoTrigger, string triggerID, bool validate = null)

Update existing trigger


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoTrigger** | [**DtoTrigger**](DtoTrigger.md) | Trigger data |  |
| **triggerID** | **string** | Trigger ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **validate** | **bool** | For validating targets | [optional]  |

### Return type

[**DtoSaveTriggerResponse**](DtoSaveTriggerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated trigger |  -  |
| **400** | Bad request from client |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |
| **503** | Remote server unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

