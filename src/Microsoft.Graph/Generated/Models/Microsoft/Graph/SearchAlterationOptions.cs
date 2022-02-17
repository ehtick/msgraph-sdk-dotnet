using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SearchAlterationOptions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether spelling modifications are enabled. If enabled, user will get the search results for corrected query when there are no results for the original query with typos and get the spelling modification information in queryAlterationResponse property of the response. Optional.</summary>
        public bool? EnableModification { get; set; }
        /// <summary>Indicates whether spelling suggestions are enabled. If enabled, user will get the search results for original search query and suggesting spelling correction in queryAlterationResponse property of the response for typos in query. Optional.</summary>
        public bool? EnableSuggestion { get; set; }
        /// <summary>
        /// Instantiates a new searchAlterationOptions and sets the default values.
        /// </summary>
        public SearchAlterationOptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"enableModification", (o,n) => { (o as SearchAlterationOptions).EnableModification = n.GetBoolValue(); } },
                {"enableSuggestion", (o,n) => { (o as SearchAlterationOptions).EnableSuggestion = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enableModification", EnableModification);
            writer.WriteBoolValue("enableSuggestion", EnableSuggestion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
