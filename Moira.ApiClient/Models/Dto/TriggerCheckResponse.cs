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
    public partial class TriggerCheckResponse : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Graphite-like targets: t1, t2, ...</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Moira.ApiClient.Models.Dto.TreeOfProblems>? Targets { get; set; }
#nullable restore
#else
        public List<global::Moira.ApiClient.Models.Dto.TreeOfProblems> Targets { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.TriggerCheckResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.ApiClient.Models.Dto.TriggerCheckResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.ApiClient.Models.Dto.TriggerCheckResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "targets", n => { Targets = n.GetCollectionOfObjectValues<global::Moira.ApiClient.Models.Dto.TreeOfProblems>(global::Moira.ApiClient.Models.Dto.TreeOfProblems.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Moira.ApiClient.Models.Dto.TreeOfProblems>("targets", Targets);
        }
    }
}
#pragma warning restore CS0618
