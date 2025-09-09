# Moira.ApiClient.Model.DtoTriggerNoisiness

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AloneMetrics** | **Dictionary&lt;string, bool&gt;** | A list of targets that have only alone metrics | 
**ClusterId** | **string** | Shows the exact cluster from where the metrics are fetched | 
**CreatedBy** | **string** | Username who created trigger | 
**EventsCount** | **int** | EventsCount for the trigger. | 
**Expression** | **string** | Used if you need more complex logic than provided by WARN/ERROR values | 
**Id** | **string** | Trigger unique ID | 
**IsRemote** | **bool** | Shows if trigger is remote (graphite-backend) based or stored inside Moira-Redis DB  Deprecated: Use TriggerSource field instead | 
**MuteNewMetrics** | **bool** | If true, first event NODATA → OK will be omitted | 
**Name** | **string** | Trigger name | 
**Patterns** | **List&lt;string&gt;** | Graphite patterns for trigger | 
**Tags** | **List&lt;string&gt;** | Set of tags to manipulate subscriptions | 
**Targets** | **List&lt;string&gt;** | Graphite-like targets: t1, t2, ... | 
**Throttling** | **long** |  | 
**TriggerSource** | **string** | Shows the type of source from where the metrics are fetched | 
**TriggerType** | **string** | Could be: rising, falling, expression | 
**UpdatedBy** | **string** | Username who updated trigger | 
**CreatedAt** | **string** | Datetime when the trigger was created | 
**Desc** | **string** | Description string | [optional] 
**ErrorValue** | **decimal** | ERROR threshold | 
**Sched** | [**MoiraScheduleData**](MoiraScheduleData.md) |  | [optional] 
**Ttl** | **long** | When there are no metrics for trigger, Moira will switch metric to TTLState state after TTL seconds | [optional] 
**TtlState** | **string** | When there are no metrics for trigger, Moira will switch metric to TTLState state after TTL seconds | [optional] 
**UpdatedAt** | **string** | Datetime  when the trigger was updated | 
**WarnValue** | **decimal** | WARN threshold | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

