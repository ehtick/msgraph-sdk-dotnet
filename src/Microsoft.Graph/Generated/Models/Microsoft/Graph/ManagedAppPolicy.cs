using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ManagedAppPolicy : Entity, IParsable {
        /// <summary>The date and time the policy was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The policy's description.</summary>
        public string Description { get; set; }
        /// <summary>Policy display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>Last time the policy was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as ManagedAppPolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagedAppPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagedAppPolicy).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ManagedAppPolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"version", (o,n) => { (o as ManagedAppPolicy).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
