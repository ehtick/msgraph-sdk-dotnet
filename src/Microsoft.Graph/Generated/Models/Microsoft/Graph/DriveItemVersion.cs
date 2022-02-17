using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DriveItemVersion : BaseItemVersion, IParsable {
        /// <summary>The content stream for this version of the item.</summary>
        public byte[] Content { get; set; }
        /// <summary>Indicates the size of the content stream for this version of the item.</summary>
        public long? Size { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as DriveItemVersion).Content = n.GetByteArrayValue(); } },
                {"size", (o,n) => { (o as DriveItemVersion).Size = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteLongValue("size", Size);
        }
    }
}
