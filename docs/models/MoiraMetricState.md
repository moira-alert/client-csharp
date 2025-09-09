# Moira.ApiClient.Model.MoiraMetricState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventTimestamp** | **long** |  | 
**State** | **string** |  | 
**Suppressed** | **bool** |  | 
**Timestamp** | **long** |  | 
**DeletedButKept** | **bool** | DeletedButKept controls whether the metric is shown to the user if the trigger has ttlState &#x3D; Del and the metric is in Maintenance. The metric remains in the database | [optional] 
**Maintenance** | **long** |  | [optional] 
**MaintenanceInfo** | [**MoiraMaintenanceInfo**](MoiraMaintenanceInfo.md) |  | 
**SuppressedState** | **string** |  | [optional] 
**Value** | **decimal** |  | [optional] 
**Values** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

