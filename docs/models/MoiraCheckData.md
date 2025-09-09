# Moira.ApiClient.Model.MoiraCheckData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastSuccessfulCheckTimestamp** | **long** | LastSuccessfulCheckTimestamp - time of the last check of the trigger, during which there were no errors | 
**Metrics** | [**Dictionary&lt;string, MoiraMetricState&gt;**](MoiraMetricState.md) |  | 
**MetricsToTargetRelation** | **Dictionary&lt;string, string&gt;** | MetricsToTargetRelation is a map that holds relation between metric names that was alone during last check and targets that fetched this metric  {\&quot;t1\&quot;: \&quot;metric.name.1\&quot;, \&quot;t2\&quot;: \&quot;metric.name.2\&quot;} | 
**Score** | **long** |  | 
**State** | **string** |  | 
**EventTimestamp** | **long** |  | [optional] 
**Maintenance** | **long** |  | [optional] 
**MaintenanceInfo** | [**MoiraMaintenanceInfo**](MoiraMaintenanceInfo.md) |  | 
**Msg** | **string** |  | [optional] 
**Suppressed** | **bool** |  | [optional] 
**SuppressedState** | **string** |  | [optional] 
**Timestamp** | **long** | Timestamp - time, which means when the checker last checked this trigger, this value stops updating if the trigger does not receive metrics | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

