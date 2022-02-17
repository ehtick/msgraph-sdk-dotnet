using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns.Item.Filter.ApplyDynamicFilter {
    public class ApplyDynamicFilterRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Criteria { get; set; }
        /// <summary>
        /// Instantiates a new applyDynamicFilterRequestBody and sets the default values.
        /// </summary>
        public ApplyDynamicFilterRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"criteria", (o,n) => { (o as ApplyDynamicFilterRequestBody).Criteria = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("criteria", Criteria);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
