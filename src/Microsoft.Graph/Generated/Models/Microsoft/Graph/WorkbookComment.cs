using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class WorkbookComment : Entity, IParsable {
        /// <summary>The content of comment.</summary>
        public string Content { get; set; }
        /// <summary>Indicates the type for the comment.</summary>
        public string ContentType { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<WorkbookCommentReply> Replies { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as WorkbookComment).Content = n.GetStringValue(); } },
                {"contentType", (o,n) => { (o as WorkbookComment).ContentType = n.GetStringValue(); } },
                {"replies", (o,n) => { (o as WorkbookComment).Replies = n.GetCollectionOfObjectValues<WorkbookCommentReply>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteCollectionOfObjectValues<WorkbookCommentReply>("replies", Replies);
        }
    }
}
