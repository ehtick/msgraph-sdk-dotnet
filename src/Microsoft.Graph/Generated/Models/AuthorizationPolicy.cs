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
    public partial class AuthorizationPolicy : global::Microsoft.Graph.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether users can sign up for email based subscriptions.</summary>
        public bool? AllowedToSignUpEmailBasedSubscriptions
        {
            get { return BackingStore?.Get<bool?>("allowedToSignUpEmailBasedSubscriptions"); }
            set { BackingStore?.Set("allowedToSignUpEmailBasedSubscriptions", value); }
        }
        /// <summary>Indicates whether administrators of the tenant can use the Self-Service Password Reset (SSPR). For more information, see Self-service password reset for administrators.</summary>
        public bool? AllowedToUseSSPR
        {
            get { return BackingStore?.Get<bool?>("allowedToUseSSPR"); }
            set { BackingStore?.Set("allowedToUseSSPR", value); }
        }
        /// <summary>Indicates whether a user can join the tenant by email validation.</summary>
        public bool? AllowEmailVerifiedUsersToJoinOrganization
        {
            get { return BackingStore?.Get<bool?>("allowEmailVerifiedUsersToJoinOrganization"); }
            set { BackingStore?.Set("allowEmailVerifiedUsersToJoinOrganization", value); }
        }
        /// <summary>Indicates who can invite guests to the organization. Possible values are: none, adminsAndGuestInviters, adminsGuestInvitersAndAllMembers, everyone.  everyone is the default setting for all cloud environments except US Government. For more information, see allowInvitesFrom values.</summary>
        public global::Microsoft.Graph.Models.AllowInvitesFrom? AllowInvitesFrom
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AllowInvitesFrom?>("allowInvitesFrom"); }
            set { BackingStore?.Set("allowInvitesFrom", value); }
        }
        /// <summary>Indicates whether user consent for risky apps is allowed. We recommend keeping allowUserConsentForRiskyApps as false. Default value is false.</summary>
        public bool? AllowUserConsentForRiskyApps
        {
            get { return BackingStore?.Get<bool?>("allowUserConsentForRiskyApps"); }
            set { BackingStore?.Set("allowUserConsentForRiskyApps", value); }
        }
        /// <summary>To disable the use of MSOL PowerShell, set this property to true. This also disables user-based access to the legacy service endpoint used by MSOL PowerShell. This doesn&apos;t affect Microsoft Entra Connect or Microsoft Graph.</summary>
        public bool? BlockMsolPowerShell
        {
            get { return BackingStore?.Get<bool?>("blockMsolPowerShell"); }
            set { BackingStore?.Set("blockMsolPowerShell", value); }
        }
        /// <summary>The defaultUserRolePermissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DefaultUserRolePermissions? DefaultUserRolePermissions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DefaultUserRolePermissions?>("defaultUserRolePermissions"); }
            set { BackingStore?.Set("defaultUserRolePermissions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DefaultUserRolePermissions DefaultUserRolePermissions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DefaultUserRolePermissions>("defaultUserRolePermissions"); }
            set { BackingStore?.Set("defaultUserRolePermissions", value); }
        }
#endif
        /// <summary>Represents role templateId for the role that should be granted to guests. Currently following roles are supported:  User (a0b1b346-4d3e-4e8b-98f8-753987be4970), Guest User (10dae51f-b6af-4016-8d66-8c2a99b929b3), and Restricted Guest User (2af84b1e-32c8-42b7-82bc-daa82404023b).</summary>
        public Guid? GuestUserRoleId
        {
            get { return BackingStore?.Get<Guid?>("guestUserRoleId"); }
            set { BackingStore?.Set("guestUserRoleId", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AuthorizationPolicy"/> and sets the default values.
        /// </summary>
        public AuthorizationPolicy() : base()
        {
            OdataType = "#microsoft.graph.authorizationPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuthorizationPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AuthorizationPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AuthorizationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowEmailVerifiedUsersToJoinOrganization", n => { AllowEmailVerifiedUsersToJoinOrganization = n.GetBoolValue(); } },
                { "allowInvitesFrom", n => { AllowInvitesFrom = n.GetEnumValue<global::Microsoft.Graph.Models.AllowInvitesFrom>(); } },
                { "allowUserConsentForRiskyApps", n => { AllowUserConsentForRiskyApps = n.GetBoolValue(); } },
                { "allowedToSignUpEmailBasedSubscriptions", n => { AllowedToSignUpEmailBasedSubscriptions = n.GetBoolValue(); } },
                { "allowedToUseSSPR", n => { AllowedToUseSSPR = n.GetBoolValue(); } },
                { "blockMsolPowerShell", n => { BlockMsolPowerShell = n.GetBoolValue(); } },
                { "defaultUserRolePermissions", n => { DefaultUserRolePermissions = n.GetObjectValue<global::Microsoft.Graph.Models.DefaultUserRolePermissions>(global::Microsoft.Graph.Models.DefaultUserRolePermissions.CreateFromDiscriminatorValue); } },
                { "guestUserRoleId", n => { GuestUserRoleId = n.GetGuidValue(); } },
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
            writer.WriteBoolValue("allowedToSignUpEmailBasedSubscriptions", AllowedToSignUpEmailBasedSubscriptions);
            writer.WriteBoolValue("allowedToUseSSPR", AllowedToUseSSPR);
            writer.WriteBoolValue("allowEmailVerifiedUsersToJoinOrganization", AllowEmailVerifiedUsersToJoinOrganization);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AllowInvitesFrom>("allowInvitesFrom", AllowInvitesFrom);
            writer.WriteBoolValue("allowUserConsentForRiskyApps", AllowUserConsentForRiskyApps);
            writer.WriteBoolValue("blockMsolPowerShell", BlockMsolPowerShell);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DefaultUserRolePermissions>("defaultUserRolePermissions", DefaultUserRolePermissions);
            writer.WriteGuidValue("guestUserRoleId", GuestUserRoleId);
        }
    }
}
#pragma warning restore CS0618
