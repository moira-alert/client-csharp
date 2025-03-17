// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Moira.ApiClient.Models.Moira
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ScheduledNotification : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The contact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Moira.ContactData? Contact { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Moira.ContactData Contact { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Moira.NotificationEvent? Event { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Moira.NotificationEvent Event { get; set; }
#endif
        /// <summary>The plotting property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Moira.PlottingData? Plotting { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Moira.PlottingData Plotting { get; set; }
#endif
        /// <summary>The send_fail property</summary>
        public int? SendFail { get; set; }
        /// <summary>The throttled property</summary>
        public bool? Throttled { get; set; }
        /// <summary>The timestamp property</summary>
        public long? Timestamp { get; set; }
        /// <summary>The trigger property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Moira.TriggerData? Trigger { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Moira.TriggerData Trigger { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Moira.ScheduledNotification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.ApiClient.Models.Moira.ScheduledNotification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.ApiClient.Models.Moira.ScheduledNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "contact", n => { Contact = n.GetObjectValue<global::Moira.ApiClient.Models.Moira.ContactData>(global::Moira.ApiClient.Models.Moira.ContactData.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "event", n => { Event = n.GetObjectValue<global::Moira.ApiClient.Models.Moira.NotificationEvent>(global::Moira.ApiClient.Models.Moira.NotificationEvent.CreateFromDiscriminatorValue); } },
                { "plotting", n => { Plotting = n.GetObjectValue<global::Moira.ApiClient.Models.Moira.PlottingData>(global::Moira.ApiClient.Models.Moira.PlottingData.CreateFromDiscriminatorValue); } },
                { "send_fail", n => { SendFail = n.GetIntValue(); } },
                { "throttled", n => { Throttled = n.GetBoolValue(); } },
                { "timestamp", n => { Timestamp = n.GetLongValue(); } },
                { "trigger", n => { Trigger = n.GetObjectValue<global::Moira.ApiClient.Models.Moira.TriggerData>(global::Moira.ApiClient.Models.Moira.TriggerData.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Moira.ContactData>("contact", Contact);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Moira.NotificationEvent>("event", Event);
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Moira.PlottingData>("plotting", Plotting);
            writer.WriteIntValue("send_fail", SendFail);
            writer.WriteBoolValue("throttled", Throttled);
            writer.WriteLongValue("timestamp", Timestamp);
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Moira.TriggerData>("trigger", Trigger);
        }
    }
}
#pragma warning restore CS0618
