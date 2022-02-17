using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class NotebookLinks : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Opens the notebook in the OneNote native client if it's installed.</summary>
        public ExternalLink OneNoteClientUrl { get; set; }
        /// <summary>Opens the notebook in OneNote on the web.</summary>
        public ExternalLink OneNoteWebUrl { get; set; }
        /// <summary>
        /// Instantiates a new notebookLinks and sets the default values.
        /// </summary>
        public NotebookLinks() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"oneNoteClientUrl", (o,n) => { (o as NotebookLinks).OneNoteClientUrl = n.GetObjectValue<ExternalLink>(); } },
                {"oneNoteWebUrl", (o,n) => { (o as NotebookLinks).OneNoteWebUrl = n.GetObjectValue<ExternalLink>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ExternalLink>("oneNoteClientUrl", OneNoteClientUrl);
            writer.WriteObjectValue<ExternalLink>("oneNoteWebUrl", OneNoteWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
