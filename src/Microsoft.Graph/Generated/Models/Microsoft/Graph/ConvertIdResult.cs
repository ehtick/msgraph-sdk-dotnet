using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ConvertIdResult : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An error object indicating the reason for the conversion failure. This value is not present if the conversion succeeded.</summary>
        public GenericError ErrorDetails { get; set; }
        /// <summary>The identifier that was converted. This value is the original, un-converted identifier.</summary>
        public string SourceId { get; set; }
        /// <summary>The converted identifier. This value is not present if the conversion failed.</summary>
        public string TargetId { get; set; }
        /// <summary>
        /// Instantiates a new ConvertIdResult and sets the default values.
        /// </summary>
        public ConvertIdResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"errorDetails", (o,n) => { (o as ConvertIdResult).ErrorDetails = n.GetObjectValue<GenericError>(); } },
                {"sourceId", (o,n) => { (o as ConvertIdResult).SourceId = n.GetStringValue(); } },
                {"targetId", (o,n) => { (o as ConvertIdResult).TargetId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GenericError>("errorDetails", ErrorDetails);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteStringValue("targetId", TargetId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
