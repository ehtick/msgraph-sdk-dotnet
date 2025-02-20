// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class UserConsentRequest : global::Microsoft.Graph.Models.Request, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Approval decisions associated with a request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Approval? Approval
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Approval?>("approval"); }
            set { BackingStore?.Set("approval", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Approval Approval
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Approval>("approval"); }
            set { BackingStore?.Set("approval", value); }
        }
#endif
        /// <summary>The user&apos;s justification for requiring access to the app. Supports $filter (eq only) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason
        {
            get { return BackingStore?.Get<string?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#nullable restore
#else
        public string Reason
        {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UserConsentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UserConsentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UserConsentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "approval", n => { Approval = n.GetObjectValue<global::Microsoft.Graph.Models.Approval>(global::Microsoft.Graph.Models.Approval.CreateFromDiscriminatorValue); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Approval>("approval", Approval);
            writer.WriteStringValue("reason", Reason);
        }
    }
}
#pragma warning restore CS0618
