using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessReviewReviewer : Entity, IParsable {
        /// <summary>The date when the reviewer was added for the access review.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Name of reviewer.</summary>
        public string DisplayName { get; set; }
        /// <summary>User principal name of the reviewer.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as AccessReviewReviewer).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as AccessReviewReviewer).DisplayName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as AccessReviewReviewer).UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
