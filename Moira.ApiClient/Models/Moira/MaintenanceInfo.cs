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
    public partial class MaintenanceInfo : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The remove_time property</summary>
        public long? RemoveTime { get; set; }
        /// <summary>The remove_user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoveUser { get; set; }
#nullable restore
#else
        public string RemoveUser { get; set; }
#endif
        /// <summary>The setup_time property</summary>
        public long? SetupTime { get; set; }
        /// <summary>The setup_user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SetupUser { get; set; }
#nullable restore
#else
        public string SetupUser { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Moira.MaintenanceInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Moira.ApiClient.Models.Moira.MaintenanceInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Moira.ApiClient.Models.Moira.MaintenanceInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "remove_time", n => { RemoveTime = n.GetLongValue(); } },
                { "remove_user", n => { RemoveUser = n.GetStringValue(); } },
                { "setup_time", n => { SetupTime = n.GetLongValue(); } },
                { "setup_user", n => { SetupUser = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("remove_time", RemoveTime);
            writer.WriteStringValue("remove_user", RemoveUser);
            writer.WriteLongValue("setup_time", SetupTime);
            writer.WriteStringValue("setup_user", SetupUser);
        }
    }
}
#pragma warning restore CS0618
