using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Workbooks.Item.Workbook.Functions.PriceMat {
    public class PriceMatRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Issue { get; set; }
        public Json Maturity { get; set; }
        public Json Rate { get; set; }
        public Json Settlement { get; set; }
        public Json Yld { get; set; }
        /// <summary>
        /// Instantiates a new priceMatRequestBody and sets the default values.
        /// </summary>
        public PriceMatRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as PriceMatRequestBody).Basis = n.GetObjectValue<Json>(); } },
                {"issue", (o,n) => { (o as PriceMatRequestBody).Issue = n.GetObjectValue<Json>(); } },
                {"maturity", (o,n) => { (o as PriceMatRequestBody).Maturity = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as PriceMatRequestBody).Rate = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as PriceMatRequestBody).Settlement = n.GetObjectValue<Json>(); } },
                {"yld", (o,n) => { (o as PriceMatRequestBody).Yld = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("issue", Issue);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteObjectValue<Json>("yld", Yld);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
