using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Solutions.BookingCurrencies {
    public class BookingCurrenciesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<BookingCurrency> Value { get; set; }
        /// <summary>
        /// Instantiates a new bookingCurrenciesResponse and sets the default values.
        /// </summary>
        public BookingCurrenciesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as BookingCurrenciesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as BookingCurrenciesResponse).Value = n.GetCollectionOfObjectValues<BookingCurrency>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<BookingCurrency>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
