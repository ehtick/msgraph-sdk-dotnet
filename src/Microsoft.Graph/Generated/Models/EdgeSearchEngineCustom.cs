// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Allows IT admins to set a custom default search engine for MDM-Controlled devices.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class EdgeSearchEngineCustom : global::Microsoft.Graph.Models.EdgeSearchEngineBase, IParsable
    {
        /// <summary>Points to a https link containing the OpenSearch xml file that contains, at minimum, the short name and the URL to the search Engine.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EdgeSearchEngineOpenSearchXmlUrl
        {
            get { return BackingStore?.Get<string?>("edgeSearchEngineOpenSearchXmlUrl"); }
            set { BackingStore?.Set("edgeSearchEngineOpenSearchXmlUrl", value); }
        }
#nullable restore
#else
        public string EdgeSearchEngineOpenSearchXmlUrl
        {
            get { return BackingStore?.Get<string>("edgeSearchEngineOpenSearchXmlUrl"); }
            set { BackingStore?.Set("edgeSearchEngineOpenSearchXmlUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.EdgeSearchEngineCustom"/> and sets the default values.
        /// </summary>
        public EdgeSearchEngineCustom() : base()
        {
            OdataType = "#microsoft.graph.edgeSearchEngineCustom";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EdgeSearchEngineCustom"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.EdgeSearchEngineCustom CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EdgeSearchEngineCustom();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "edgeSearchEngineOpenSearchXmlUrl", n => { EdgeSearchEngineOpenSearchXmlUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("edgeSearchEngineOpenSearchXmlUrl", EdgeSearchEngineOpenSearchXmlUrl);
        }
    }
}
#pragma warning restore CS0618
