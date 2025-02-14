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
    /// Windows Autopilot Deployment Profile
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WindowsAutopilotDeploymentProfile : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>The list of assigned devices for the profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.WindowsAutopilotDeviceIdentity>? AssignedDevices
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WindowsAutopilotDeviceIdentity>?>("assignedDevices"); }
            set { BackingStore?.Set("assignedDevices", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.WindowsAutopilotDeviceIdentity> AssignedDevices
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.WindowsAutopilotDeviceIdentity>>("assignedDevices"); }
            set { BackingStore?.Set("assignedDevices", value); }
        }
#endif
        /// <summary>The date and time of when the deployment profile was created. The value cannot be modified and is automatically populated when the profile was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported. Read-Only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>A description of the deployment profile. Max allowed length is 1500 chars. Supports: $select, $top, $skip, $orderBy. $Search and $filter are not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The template used to name the Autopilot device. This can be a custom text and can also contain either the serial number of the device, or a randomly generated number. The total length of the text generated by the template can be no more than 15 characters. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceNameTemplate
        {
            get { return BackingStore?.Get<string?>("deviceNameTemplate"); }
            set { BackingStore?.Set("deviceNameTemplate", value); }
        }
#nullable restore
#else
        public string DeviceNameTemplate
        {
            get { return BackingStore?.Get<string>("deviceNameTemplate"); }
            set { BackingStore?.Set("deviceNameTemplate", value); }
        }
#endif
        /// <summary>The deviceType property</summary>
        public global::Microsoft.Graph.Models.WindowsAutopilotDeviceType? DeviceType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.WindowsAutopilotDeviceType?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>The display name of the deployment profile. Max allowed length is 200 chars. Returned by default. Supports: $select, $top, $skip, $orderby. $Search and $filter are not supported.</summary>
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
        /// <summary>Indicates whether the profile supports the extraction of hardware hash values and registration of the device into Windows Autopilot. When TRUE, indicates if hardware extraction and Windows Autopilot registration will happen on the next successful check-in. When FALSE, hardware hash extraction and Windows Autopilot registration will not happen. Default value is FALSE. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported.</summary>
        public bool? HardwareHashExtractionEnabled
        {
            get { return BackingStore?.Get<bool?>("hardwareHashExtractionEnabled"); }
            set { BackingStore?.Set("hardwareHashExtractionEnabled", value); }
        }
        /// <summary>The date and time of when the deployment profile was last modified. The value cannot be updated manually and is automatically populated when any changes are made to the profile. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported Read-Only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The locale (language) to be used when configuring the device. E.g. en-US. The default value is os-default. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale
        {
            get { return BackingStore?.Get<string?>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#nullable restore
#else
        public string Locale
        {
            get { return BackingStore?.Get<string>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#endif
        /// <summary>The Entra management service App ID which gets used during client device-based enrollment discovery. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementServiceAppId
        {
            get { return BackingStore?.Get<string?>("managementServiceAppId"); }
            set { BackingStore?.Set("managementServiceAppId", value); }
        }
#nullable restore
#else
        public string ManagementServiceAppId
        {
            get { return BackingStore?.Get<string>("managementServiceAppId"); }
            set { BackingStore?.Set("managementServiceAppId", value); }
        }
#endif
        /// <summary>The Windows Autopilot Deployment Profile settings used by the device for the out-of-box experience. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.OutOfBoxExperienceSetting? OutOfBoxExperienceSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OutOfBoxExperienceSetting?>("outOfBoxExperienceSetting"); }
            set { BackingStore?.Set("outOfBoxExperienceSetting", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.OutOfBoxExperienceSetting OutOfBoxExperienceSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.OutOfBoxExperienceSetting>("outOfBoxExperienceSetting"); }
            set { BackingStore?.Set("outOfBoxExperienceSetting", value); }
        }
#endif
        /// <summary>Indicates whether the user is allowed to use Windows Autopilot for pre-provisioned deployment mode during Out of Box experience (OOBE). When TRUE, indicates that Windows Autopilot for pre-provisioned deployment mode for OOBE is allowed to be used. When false, Windows Autopilot for pre-provisioned deployment mode for OOBE is not allowed. The default is FALSE.</summary>
        public bool? PreprovisioningAllowed
        {
            get { return BackingStore?.Get<bool?>("preprovisioningAllowed"); }
            set { BackingStore?.Set("preprovisioningAllowed", value); }
        }
        /// <summary>List of role scope tags for the deployment profile. </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.WindowsAutopilotDeploymentProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.WindowsAutopilotDeploymentProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.WindowsAutopilotDeploymentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignedDevices", n => { AssignedDevices = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.WindowsAutopilotDeviceIdentity>(global::Microsoft.Graph.Models.WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceNameTemplate", n => { DeviceNameTemplate = n.GetStringValue(); } },
                { "deviceType", n => { DeviceType = n.GetEnumValue<global::Microsoft.Graph.Models.WindowsAutopilotDeviceType>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "hardwareHashExtractionEnabled", n => { HardwareHashExtractionEnabled = n.GetBoolValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "locale", n => { Locale = n.GetStringValue(); } },
                { "managementServiceAppId", n => { ManagementServiceAppId = n.GetStringValue(); } },
                { "outOfBoxExperienceSetting", n => { OutOfBoxExperienceSetting = n.GetObjectValue<global::Microsoft.Graph.Models.OutOfBoxExperienceSetting>(global::Microsoft.Graph.Models.OutOfBoxExperienceSetting.CreateFromDiscriminatorValue); } },
                { "preprovisioningAllowed", n => { PreprovisioningAllowed = n.GetBoolValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.WindowsAutopilotDeviceIdentity>("assignedDevices", AssignedDevices);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("deviceNameTemplate", DeviceNameTemplate);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.WindowsAutopilotDeviceType>("deviceType", DeviceType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hardwareHashExtractionEnabled", HardwareHashExtractionEnabled);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteStringValue("managementServiceAppId", ManagementServiceAppId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.OutOfBoxExperienceSetting>("outOfBoxExperienceSetting", OutOfBoxExperienceSetting);
            writer.WriteBoolValue("preprovisioningAllowed", PreprovisioningAllowed);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
#pragma warning restore CS0618
