# Moira.ApiClient.Api.ContactApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewContact**](ContactApi.md#createnewcontact) | **PUT** /contact | Creates a new contact notification for the current user |
| [**GetAllContacts**](ContactApi.md#getallcontacts) | **GET** /contact | Gets all Moira contacts |
| [**GetContactById**](ContactApi.md#getcontactbyid) | **GET** /contact/{contactID} | Get contact by ID |
| [**GetContactEventsById**](ContactApi.md#getcontacteventsbyid) | **GET** /contact/{contactID}/events | Get contact events by ID with time range |
| [**GetContactsNoisiness**](ContactApi.md#getcontactsnoisiness) | **GET** /contact/noisiness | Get contacts noisiness |
| [**RemoveContact**](ContactApi.md#removecontact) | **DELETE** /contact/{contactID} | Deletes notification contact for the current user and remove the contact ID from all subscriptions |
| [**SendTestContactNotification**](ContactApi.md#sendtestcontactnotification) | **POST** /contact/{contactID}/test | Push a test notification to verify that the contact is properly set up |
| [**UpdateContact**](ContactApi.md#updatecontact) | **PUT** /contact/{contactID} | Updates an existing notification contact to the values passed in the request body |

<a id="createnewcontact"></a>
# **CreateNewContact**
> DtoContact CreateNewContact (DtoContact dtoContact)

Creates a new contact notification for the current user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoContact** | [**DtoContact**](DtoContact.md) | Contact data |  |

### Return type

[**DtoContact**](DtoContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact created successfully |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallcontacts"></a>
# **GetAllContacts**
> DtoContactList GetAllContacts ()

Gets all Moira contacts


### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoContactList**](DtoContactList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contacts fetched successfully |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcontactbyid"></a>
# **GetContactById**
> DtoContact GetContactById (string contactID)

Get contact by ID


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactID** | **string** | Contact ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoContact**](DtoContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully received contact |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcontacteventsbyid"></a>
# **GetContactEventsById**
> DtoContactEventItemList GetContactEventsById (string contactID, string from = null, string to = null, int size = null, int p = null)

Get contact events by ID with time range


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactID** | **string** | Contact ID | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **from** | **string** | Start time of the time range | [optional] [default to &quot;-3hour&quot;] |
| **to** | **string** | End time of the time range | [optional] [default to &quot;now&quot;] |
| **size** | **int** | Number of items to return or all items if size &#x3D;&#x3D; -1 (if size &#x3D;&#x3D; -1 p should be zero for correct work) | [optional] [default to 100] |
| **p** | **int** | Defines the index of data portion (combined with size). E.g, p&#x3D;2, size&#x3D;100 will return records from 200 (including), to 300 (not including) | [optional] [default to 0] |

### Return type

[**DtoContactEventItemList**](DtoContactEventItemList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully received contact events |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcontactsnoisiness"></a>
# **GetContactsNoisiness**
> DtoContactNoisinessList GetContactsNoisiness (int size = null, int p = null, string from = null, string to = null, string sort = null)

Get contacts noisiness


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **size** | **int** | Number of items to be displayed on one page. if size &#x3D; -1 then all events returned | [optional] [default to 100] |
| **p** | **int** | Defines the number of the displayed page. E.g, p&#x3D;2 would display the 2nd page | [optional] [default to 0] |
| **from** | **string** | Start time of the time range | [optional] [default to &quot;-3hours&quot;] |
| **to** | **string** | End time of the time range | [optional] [default to &quot;now&quot;] |
| **sort** | **string** | String to set sort order (by events_count). On empty - no order, asc - ascending, desc - descending | [optional] [default to &quot;desc&quot;] |

### Return type

[**DtoContactNoisinessList**](DtoContactNoisinessList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get noisiness for contacts in range |  -  |
| **400** | Bad request from client |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removecontact"></a>
# **RemoveContact**
> Object RemoveContact (string contactID, Object body = null)

Deletes notification contact for the current user and remove the contact ID from all subscriptions


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactID** | **string** | ID of the contact to remove | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **body** | **Object** |  | [optional]  |

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
| **200** | Contact has been deleted |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtestcontactnotification"></a>
# **SendTestContactNotification**
> Object SendTestContactNotification (string contactID, Object body = null)

Push a test notification to verify that the contact is properly set up


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactID** | **string** | The ID of the target contact | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |
| **body** | **Object** |  | [optional]  |

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
| **200** | Test successful |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecontact"></a>
# **UpdateContact**
> DtoContact UpdateContact (DtoContact dtoContact, string contactID)

Updates an existing notification contact to the values passed in the request body


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dtoContact** | [**DtoContact**](DtoContact.md) | Updated contact data |  |
| **contactID** | **string** | ID of the contact to update | [default to &quot;bcba82f5-48cf-44c0-b7d6-e1d32c64a88c&quot;] |

### Return type

[**DtoContact**](DtoContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated contact |  -  |
| **400** | Bad request from client |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource not found |  -  |
| **422** | Render error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

