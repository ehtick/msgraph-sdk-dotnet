using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Workbooks.Item.Workbook.Functions.PercentRank_Exc {
    public class PercentRank_ExcRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Array { get; set; }
        public Json Significance { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new percentRank_ExcRequestBody and sets the default values.
        /// </summary>
        public PercentRank_ExcRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"array", (o,n) => { (o as PercentRank_ExcRequestBody).Array = n.GetObjectValue<Json>(); } },
                {"significance", (o,n) => { (o as PercentRank_ExcRequestBody).Significance = n.GetObjectValue<Json>(); } },
                {"x", (o,n) => { (o as PercentRank_ExcRequestBody).X = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("array", Array);
            writer.WriteObjectValue<Json>("significance", Significance);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
