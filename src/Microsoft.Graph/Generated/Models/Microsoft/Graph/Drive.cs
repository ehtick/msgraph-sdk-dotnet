using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Drive : BaseItem, IParsable {
        /// <summary>Collection of [bundles][bundle] (albums and multi-select-shared sets of items). Only in personal OneDrive.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.DriveItem> Bundles { get; set; }
        /// <summary>Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.</summary>
        public string DriveType { get; set; }
        /// <summary>The list of items the user is following. Only in OneDrive for Business.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.DriveItem> Following { get; set; }
        /// <summary>All items contained in the drive. Read-only. Nullable.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.DriveItem> Items { get; set; }
        /// <summary>For drives in SharePoint, the underlying document library list. Read-only. Nullable.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.List List { get; set; }
        /// <summary>Optional. The user account that owns the drive. Read-only.</summary>
        public IdentitySet Owner { get; set; }
        /// <summary>Optional. Information about the drive's storage space quota. Read-only.</summary>
        public Quota Quota { get; set; }
        /// <summary>The root folder of the drive. Read-only.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.DriveItem Root { get; set; }
        public SharepointIds SharePointIds { get; set; }
        /// <summary>Collection of common folders available in OneDrive. Read-only. Nullable.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.DriveItem> Special { get; set; }
        /// <summary>If present, indicates that this is a system-managed drive. Read-only.</summary>
        public SystemFacet System { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bundles", (o,n) => { (o as Drive).Bundles = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>().ToList(); } },
                {"driveType", (o,n) => { (o as Drive).DriveType = n.GetStringValue(); } },
                {"following", (o,n) => { (o as Drive).Following = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>().ToList(); } },
                {"items", (o,n) => { (o as Drive).Items = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>().ToList(); } },
                {"list", (o,n) => { (o as Drive).List = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.List>(); } },
                {"owner", (o,n) => { (o as Drive).Owner = n.GetObjectValue<IdentitySet>(); } },
                {"quota", (o,n) => { (o as Drive).Quota = n.GetObjectValue<Quota>(); } },
                {"root", (o,n) => { (o as Drive).Root = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>(); } },
                {"sharePointIds", (o,n) => { (o as Drive).SharePointIds = n.GetObjectValue<SharepointIds>(); } },
                {"special", (o,n) => { (o as Drive).Special = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>().ToList(); } },
                {"system", (o,n) => { (o as Drive).System = n.GetObjectValue<SystemFacet>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>("bundles", Bundles);
            writer.WriteStringValue("driveType", DriveType);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>("following", Following);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>("items", Items);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.List>("list", List);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<Quota>("quota", Quota);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>("root", Root);
            writer.WriteObjectValue<SharepointIds>("sharePointIds", SharePointIds);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.DriveItem>("special", Special);
            writer.WriteObjectValue<SystemFacet>("system", System);
        }
    }
}
