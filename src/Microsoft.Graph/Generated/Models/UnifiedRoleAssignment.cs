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
    public partial class UnifiedRoleAssignment : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only property with details of the app specific scope when the assignment scope is app specific. Containment entity. Supports $expand for the entitlement provider only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.AppScope? AppScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppScope?>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.AppScope AppScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppScope>("appScope"); }
            set { BackingStore?.Set("appScope", value); }
        }
#endif
        /// <summary>Identifier of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by a resource application only. For the entitlement management provider, use this property to specify a catalog. For example, /AccessPackageCatalog/beedadfe-01d5-4025-910b-84abb9369997. Supports $filter (eq, in). For example, /roleManagement/entitlementManagement/roleAssignments?$filter=appScopeId eq &apos;/AccessPackageCatalog/{catalog id}&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppScopeId
        {
            get { return BackingStore?.Get<string?>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#nullable restore
#else
        public string AppScopeId
        {
            get { return BackingStore?.Get<string>("appScopeId"); }
            set { BackingStore?.Set("appScopeId", value); }
        }
#endif
        /// <summary>The condition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Condition
        {
            get { return BackingStore?.Get<string?>("condition"); }
            set { BackingStore?.Set("condition", value); }
        }
#nullable restore
#else
        public string Condition
        {
            get { return BackingStore?.Get<string>("condition"); }
            set { BackingStore?.Set("condition", value); }
        }
#endif
        /// <summary>The directory object that is the scope of the assignment. Read-only. Supports $expand for the directory provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DirectoryObject? DirectoryScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject?>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DirectoryObject DirectoryScope
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject>("directoryScope"); }
            set { BackingStore?.Set("directoryScope", value); }
        }
#endif
        /// <summary>Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications, unlike app scopes that are defined and understood by a resource application only. Supports $filter (eq, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectoryScopeId
        {
            get { return BackingStore?.Get<string?>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#nullable restore
#else
        public string DirectoryScopeId
        {
            get { return BackingStore?.Get<string>("directoryScopeId"); }
            set { BackingStore?.Set("directoryScopeId", value); }
        }
#endif
        /// <summary>Referencing the assigned principal. Read-only. Supports $expand except for the Exchange provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DirectoryObject? Principal
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DirectoryObject Principal
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>Identifier of the principal to which the assignment is granted. Supported principals are users, role-assignable groups, and service principals. Supports $filter (eq, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId
        {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId
        {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>The roleDefinition the assignment is for. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.UnifiedRoleDefinition? RoleDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleDefinition?>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.UnifiedRoleDefinition RoleDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.UnifiedRoleDefinition>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#endif
        /// <summary>Identifier of the unifiedRoleDefinition the assignment is for. Read-only. Supports $filter (eq, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId
        {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#nullable restore
#else
        public string RoleDefinitionId
        {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UnifiedRoleAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UnifiedRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UnifiedRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appScope", n => { AppScope = n.GetObjectValue<global::Microsoft.Graph.Models.AppScope>(global::Microsoft.Graph.Models.AppScope.CreateFromDiscriminatorValue); } },
                { "appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                { "condition", n => { Condition = n.GetStringValue(); } },
                { "directoryScope", n => { DirectoryScope = n.GetObjectValue<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                { "principal", n => { Principal = n.GetObjectValue<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "principalId", n => { PrincipalId = n.GetStringValue(); } },
                { "roleDefinition", n => { RoleDefinition = n.GetObjectValue<global::Microsoft.Graph.Models.UnifiedRoleDefinition>(global::Microsoft.Graph.Models.UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteStringValue("condition", Condition);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
        }
    }
}
#pragma warning restore CS0618
