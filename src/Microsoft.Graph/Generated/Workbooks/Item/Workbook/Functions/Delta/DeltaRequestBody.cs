using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Workbooks.Item.Workbook.Functions.Delta {
    public class DeltaRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Number1 { get; set; }
        public Json Number2 { get; set; }
        /// <summary>
        /// Instantiates a new deltaRequestBody and sets the default values.
        /// </summary>
        public DeltaRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"number1", (o,n) => { (o as DeltaRequestBody).Number1 = n.GetObjectValue<Json>(); } },
                {"number2", (o,n) => { (o as DeltaRequestBody).Number2 = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("number1", Number1);
            writer.WriteObjectValue<Json>("number2", Number2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
