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
    public partial class UserRegistrationMethodSummary : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Total number of users in the tenant.</summary>
        public long? TotalUserCount
        {
            get { return BackingStore?.Get<long?>("totalUserCount"); }
            set { BackingStore?.Set("totalUserCount", value); }
        }
        /// <summary>Number of users registered for each authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.UserRegistrationMethodCount>? UserRegistrationMethodCounts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserRegistrationMethodCount>?>("userRegistrationMethodCounts"); }
            set { BackingStore?.Set("userRegistrationMethodCounts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.UserRegistrationMethodCount> UserRegistrationMethodCounts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserRegistrationMethodCount>>("userRegistrationMethodCounts"); }
            set { BackingStore?.Set("userRegistrationMethodCounts", value); }
        }
#endif
        /// <summary>The role type of the user. Possible values are: all, privilegedAdmin, admin, user, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.IncludedUserRoles? UserRoles
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IncludedUserRoles?>("userRoles"); }
            set { BackingStore?.Set("userRoles", value); }
        }
        /// <summary>User type. Possible values are: all, member, guest, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.IncludedUserTypes? UserTypes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IncludedUserTypes?>("userTypes"); }
            set { BackingStore?.Set("userTypes", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.UserRegistrationMethodSummary"/> and sets the default values.
        /// </summary>
        public UserRegistrationMethodSummary()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UserRegistrationMethodSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.UserRegistrationMethodSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UserRegistrationMethodSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "totalUserCount", n => { TotalUserCount = n.GetLongValue(); } },
                { "userRegistrationMethodCounts", n => { UserRegistrationMethodCounts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.UserRegistrationMethodCount>(global::Microsoft.Graph.Models.UserRegistrationMethodCount.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userRoles", n => { UserRoles = n.GetEnumValue<global::Microsoft.Graph.Models.IncludedUserRoles>(); } },
                { "userTypes", n => { UserTypes = n.GetEnumValue<global::Microsoft.Graph.Models.IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.UserRegistrationMethodCount>("userRegistrationMethodCounts", UserRegistrationMethodCounts);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
