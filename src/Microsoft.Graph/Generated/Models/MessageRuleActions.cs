// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class MessageRuleActions : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>A list of categories to be assigned to a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssignCategories
        {
            get { return BackingStore?.Get<List<string>?>("assignCategories"); }
            set { BackingStore?.Set("assignCategories", value); }
        }
#nullable restore
#else
        public List<string> AssignCategories
        {
            get { return BackingStore?.Get<List<string>>("assignCategories"); }
            set { BackingStore?.Set("assignCategories", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ID of a folder that a message is to be copied to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CopyToFolder
        {
            get { return BackingStore?.Get<string?>("copyToFolder"); }
            set { BackingStore?.Set("copyToFolder", value); }
        }
#nullable restore
#else
        public string CopyToFolder
        {
            get { return BackingStore?.Get<string>("copyToFolder"); }
            set { BackingStore?.Set("copyToFolder", value); }
        }
#endif
        /// <summary>Indicates whether a message should be moved to the Deleted Items folder.</summary>
        public bool? Delete
        {
            get { return BackingStore?.Get<bool?>("delete"); }
            set { BackingStore?.Set("delete", value); }
        }
        /// <summary>The email addresses of the recipients to which a message should be forwarded as an attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Recipient>? ForwardAsAttachmentTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Recipient>?>("forwardAsAttachmentTo"); }
            set { BackingStore?.Set("forwardAsAttachmentTo", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Recipient> ForwardAsAttachmentTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Recipient>>("forwardAsAttachmentTo"); }
            set { BackingStore?.Set("forwardAsAttachmentTo", value); }
        }
#endif
        /// <summary>The email addresses of the recipients to which a message should be forwarded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Recipient>? ForwardTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Recipient>?>("forwardTo"); }
            set { BackingStore?.Set("forwardTo", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Recipient> ForwardTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Recipient>>("forwardTo"); }
            set { BackingStore?.Set("forwardTo", value); }
        }
#endif
        /// <summary>Indicates whether a message should be marked as read.</summary>
        public bool? MarkAsRead
        {
            get { return BackingStore?.Get<bool?>("markAsRead"); }
            set { BackingStore?.Set("markAsRead", value); }
        }
        /// <summary>Sets the importance of the message, which can be: low, normal, high.</summary>
        public global::Microsoft.Graph.Models.Importance? MarkImportance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Importance?>("markImportance"); }
            set { BackingStore?.Set("markImportance", value); }
        }
        /// <summary>The ID of the folder that a message will be moved to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MoveToFolder
        {
            get { return BackingStore?.Get<string?>("moveToFolder"); }
            set { BackingStore?.Set("moveToFolder", value); }
        }
#nullable restore
#else
        public string MoveToFolder
        {
            get { return BackingStore?.Get<string>("moveToFolder"); }
            set { BackingStore?.Set("moveToFolder", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Indicates whether a message should be permanently deleted and not saved to the Deleted Items folder.</summary>
        public bool? PermanentDelete
        {
            get { return BackingStore?.Get<bool?>("permanentDelete"); }
            set { BackingStore?.Set("permanentDelete", value); }
        }
        /// <summary>The email addresses to which a message should be redirected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Recipient>? RedirectTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Recipient>?>("redirectTo"); }
            set { BackingStore?.Set("redirectTo", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Recipient> RedirectTo
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Recipient>>("redirectTo"); }
            set { BackingStore?.Set("redirectTo", value); }
        }
#endif
        /// <summary>Indicates whether subsequent rules should be evaluated.</summary>
        public bool? StopProcessingRules
        {
            get { return BackingStore?.Get<bool?>("stopProcessingRules"); }
            set { BackingStore?.Set("stopProcessingRules", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.MessageRuleActions"/> and sets the default values.
        /// </summary>
        public MessageRuleActions()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.MessageRuleActions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.MessageRuleActions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.MessageRuleActions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignCategories", n => { AssignCategories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "copyToFolder", n => { CopyToFolder = n.GetStringValue(); } },
                { "delete", n => { Delete = n.GetBoolValue(); } },
                { "forwardAsAttachmentTo", n => { ForwardAsAttachmentTo = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Recipient>(global::Microsoft.Graph.Models.Recipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "forwardTo", n => { ForwardTo = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Recipient>(global::Microsoft.Graph.Models.Recipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "markAsRead", n => { MarkAsRead = n.GetBoolValue(); } },
                { "markImportance", n => { MarkImportance = n.GetEnumValue<global::Microsoft.Graph.Models.Importance>(); } },
                { "moveToFolder", n => { MoveToFolder = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "permanentDelete", n => { PermanentDelete = n.GetBoolValue(); } },
                { "redirectTo", n => { RedirectTo = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Recipient>(global::Microsoft.Graph.Models.Recipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "stopProcessingRules", n => { StopProcessingRules = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("assignCategories", AssignCategories);
            writer.WriteStringValue("copyToFolder", CopyToFolder);
            writer.WriteBoolValue("delete", Delete);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Recipient>("forwardAsAttachmentTo", ForwardAsAttachmentTo);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Recipient>("forwardTo", ForwardTo);
            writer.WriteBoolValue("markAsRead", MarkAsRead);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Importance>("markImportance", MarkImportance);
            writer.WriteStringValue("moveToFolder", MoveToFolder);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("permanentDelete", PermanentDelete);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Recipient>("redirectTo", RedirectTo);
            writer.WriteBoolValue("stopProcessingRules", StopProcessingRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
