using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Workbooks.Item.Workbook.Functions.F_Dist {
    public class F_DistRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cumulative { get; set; }
        public Json DegFreedom1 { get; set; }
        public Json DegFreedom2 { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new f_DistRequestBody and sets the default values.
        /// </summary>
        public F_DistRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cumulative", (o,n) => { (o as F_DistRequestBody).Cumulative = n.GetObjectValue<Json>(); } },
                {"degFreedom1", (o,n) => { (o as F_DistRequestBody).DegFreedom1 = n.GetObjectValue<Json>(); } },
                {"degFreedom2", (o,n) => { (o as F_DistRequestBody).DegFreedom2 = n.GetObjectValue<Json>(); } },
                {"x", (o,n) => { (o as F_DistRequestBody).X = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("degFreedom1", DegFreedom1);
            writer.WriteObjectValue<Json>("degFreedom2", DegFreedom2);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
