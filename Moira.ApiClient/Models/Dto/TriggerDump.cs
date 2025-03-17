// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Moira.ApiClient.Models.Moira;
using System.Collections.Generic;
using System.IO;
using System;
namespace Moira.ApiClient.Models.Dto
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TriggerDump : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The created property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Created { get; set; }
#nullable restore
#else
        public string Created { get; set; }
#endif
        /// <summary>The last_check property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Moira.CheckData? LastCheck { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Moira.CheckData LastCheck { get; set; }
#endif
        /// <summary>The metrics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Moira.ApiClient.Models.Dto.PatternMetrics>? Metrics { get; set; }
#nullable restore
#else
        public List<global::Moira.ApiClient.Models.Dto.PatternMetrics> Metrics { get; set; }
#endif
        /// <summary>The trigger property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Moira.Trigger? Trigger { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Moira.Trigger Trigger { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.TriggerDump"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.ApiClient.Models.Dto.TriggerDump CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.ApiClient.Models.Dto.TriggerDump();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created", n => { Created = n.GetStringValue(); } },
                { "last_check", n => { LastCheck = n.GetObjectValue<global::Moira.ApiClient.Models.Moira.CheckData>(global::Moira.ApiClient.Models.Moira.CheckData.CreateFromDiscriminatorValue); } },
                { "metrics", n => { Metrics = n.GetCollectionOfObjectValues<global::Moira.ApiClient.Models.Dto.PatternMetrics>(global::Moira.ApiClient.Models.Dto.PatternMetrics.CreateFromDiscriminatorValue)?.AsList(); } },
                { "trigger", n => { Trigger = n.GetObjectValue<global::Moira.ApiClient.Models.Moira.Trigger>(global::Moira.ApiClient.Models.Moira.Trigger.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("created", Created);
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Moira.CheckData>("last_check", LastCheck);
            writer.WriteCollectionOfObjectValues<global::Moira.ApiClient.Models.Dto.PatternMetrics>("metrics", Metrics);
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Moira.Trigger>("trigger", Trigger);
        }
    }
}
#pragma warning restore CS0618
