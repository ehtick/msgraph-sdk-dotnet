using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Communications.Calls.Item.UpdateRecordingStatus {
    public class UpdateRecordingStatusRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClientContext { get; set; }
        public RecordingStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new updateRecordingStatusRequestBody and sets the default values.
        /// </summary>
        public UpdateRecordingStatusRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientContext", (o,n) => { (o as UpdateRecordingStatusRequestBody).ClientContext = n.GetStringValue(); } },
                {"status", (o,n) => { (o as UpdateRecordingStatusRequestBody).Status = n.GetEnumValue<RecordingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteEnumValue<RecordingStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
