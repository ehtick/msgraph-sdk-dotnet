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
    public partial class UserTrainingEventInfo : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Display name of the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Latest status of the training assigned to the user. Possible values are: unknown, assigned, inProgress, completed, overdue, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.TrainingStatus? LatestTrainingStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TrainingStatus?>("latestTrainingStatus"); }
            set { BackingStore?.Set("latestTrainingStatus", value); }
        }
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
        /// <summary>Event details of the training when it was assigned to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UserTrainingContentEventInfo? TrainingAssignedProperties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserTrainingContentEventInfo?>("trainingAssignedProperties"); }
            set { BackingStore?.Set("trainingAssignedProperties", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UserTrainingContentEventInfo TrainingAssignedProperties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>("trainingAssignedProperties"); }
            set { BackingStore?.Set("trainingAssignedProperties", value); }
        }
#endif
        /// <summary>Event details of the training when it was completed by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UserTrainingContentEventInfo? TrainingCompletedProperties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserTrainingContentEventInfo?>("trainingCompletedProperties"); }
            set { BackingStore?.Set("trainingCompletedProperties", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UserTrainingContentEventInfo TrainingCompletedProperties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>("trainingCompletedProperties"); }
            set { BackingStore?.Set("trainingCompletedProperties", value); }
        }
#endif
        /// <summary>Event details of the training when it was updated/in-progress by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UserTrainingContentEventInfo? TrainingUpdatedProperties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserTrainingContentEventInfo?>("trainingUpdatedProperties"); }
            set { BackingStore?.Set("trainingUpdatedProperties", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UserTrainingContentEventInfo TrainingUpdatedProperties
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>("trainingUpdatedProperties"); }
            set { BackingStore?.Set("trainingUpdatedProperties", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.UserTrainingEventInfo"/> and sets the default values.
        /// </summary>
        public UserTrainingEventInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UserTrainingEventInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.UserTrainingEventInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UserTrainingEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "latestTrainingStatus", n => { LatestTrainingStatus = n.GetEnumValue<global::Microsoft.Graph.Models.TrainingStatus>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "trainingAssignedProperties", n => { TrainingAssignedProperties = n.GetObjectValue<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>(global::Microsoft.Graph.Models.UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                { "trainingCompletedProperties", n => { TrainingCompletedProperties = n.GetObjectValue<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>(global::Microsoft.Graph.Models.UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                { "trainingUpdatedProperties", n => { TrainingUpdatedProperties = n.GetObjectValue<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>(global::Microsoft.Graph.Models.UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TrainingStatus>("latestTrainingStatus", LatestTrainingStatus);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>("trainingAssignedProperties", TrainingAssignedProperties);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>("trainingCompletedProperties", TrainingCompletedProperties);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UserTrainingContentEventInfo>("trainingUpdatedProperties", TrainingUpdatedProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
