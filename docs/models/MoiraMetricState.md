# Moira.ApiClient.Model.MoiraMetricState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventTimestamp** | **long** |  | 
**State** | **string** |  | 
**Suppressed** | **bool** |  | 
**Timestamp** | **long** |  | 
**DeletedButKept** | **bool** | DeletedButKept controls whether the metric is shown to the user if the trigger has ttlState &#x3D; Del and the metric is in Maintenance. The metric remains in the database | [optional] 
**ErrorRecoverSince** | **long** | ErrorRecoverSince is the unix timestamp when the metric first dropped below ErrorValue after ERROR had fired, 0 if not currently tracked. | [optional] 
**ErrorSince** | **long** | ErrorSince is the unix timestamp when the metric first became continuously &gt;&#x3D; ErrorValue, 0 if not currently tracked. | [optional] 
**Maintenance** | **long** |  | [optional] 
**MaintenanceInfo** | [**MoiraMaintenanceInfo**](MoiraMaintenanceInfo.md) |  | 
**SuppressedState** | **string** |  | [optional] 
**Value** | **decimal** |  | [optional] 
**Values** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 
**WarnRecoverSince** | **long** | WarnRecoverSince is the unix timestamp when the metric first dropped below WarnValue after WARN had fired, 0 if not currently tracked. | [optional] 
**WarnSince** | **long** | AloneMetrics    map[string]string  &#x60;json:\&quot;alone_metrics\&quot;&#x60; // represents a relation between name of alone metrics and their targets WarnSince is the unix timestamp when the metric first became continuously &gt;&#x3D; WarnValue, 0 if not currently tracked. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

