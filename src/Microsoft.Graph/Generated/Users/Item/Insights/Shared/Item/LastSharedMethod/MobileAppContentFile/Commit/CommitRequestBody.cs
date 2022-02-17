using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Users.Item.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile.Commit {
    public class CommitRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public FileEncryptionInfo FileEncryptionInfo { get; set; }
        /// <summary>
        /// Instantiates a new commitRequestBody and sets the default values.
        /// </summary>
        public CommitRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fileEncryptionInfo", (o,n) => { (o as CommitRequestBody).FileEncryptionInfo = n.GetObjectValue<FileEncryptionInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<FileEncryptionInfo>("fileEncryptionInfo", FileEncryptionInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
