// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Moira.ApiClient.Models.Dto
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PatternMetrics : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The metrics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Dto.PatternMetrics_metrics? Metrics { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Dto.PatternMetrics_metrics Metrics { get; set; }
#endif
        /// <summary>The pattern property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pattern { get; set; }
#nullable restore
#else
        public string Pattern { get; set; }
#endif
        /// <summary>The retention property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Moira.ApiClient.Models.Dto.PatternMetrics_retention? Retention { get; set; }
#nullable restore
#else
        public global::Moira.ApiClient.Models.Dto.PatternMetrics_retention Retention { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.PatternMetrics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.ApiClient.Models.Dto.PatternMetrics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.ApiClient.Models.Dto.PatternMetrics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "metrics", n => { Metrics = n.GetObjectValue<global::Moira.ApiClient.Models.Dto.PatternMetrics_metrics>(global::Moira.ApiClient.Models.Dto.PatternMetrics_metrics.CreateFromDiscriminatorValue); } },
                { "pattern", n => { Pattern = n.GetStringValue(); } },
                { "retention", n => { Retention = n.GetObjectValue<global::Moira.ApiClient.Models.Dto.PatternMetrics_retention>(global::Moira.ApiClient.Models.Dto.PatternMetrics_retention.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Dto.PatternMetrics_metrics>("metrics", Metrics);
            writer.WriteStringValue("pattern", Pattern);
            writer.WriteObjectValue<global::Moira.ApiClient.Models.Dto.PatternMetrics_retention>("retention", Retention);
        }
    }
}
#pragma warning restore CS0618
