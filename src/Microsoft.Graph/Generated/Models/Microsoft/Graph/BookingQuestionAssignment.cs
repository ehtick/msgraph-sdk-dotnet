using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class BookingQuestionAssignment : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the custom question.</summary>
        public bool? IsRequired { get; set; }
        /// <summary>Indicates whether it is mandatory to answer the custom question.</summary>
        public string QuestionId { get; set; }
        /// <summary>
        /// Instantiates a new bookingQuestionAssignment and sets the default values.
        /// </summary>
        public BookingQuestionAssignment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isRequired", (o,n) => { (o as BookingQuestionAssignment).IsRequired = n.GetBoolValue(); } },
                {"questionId", (o,n) => { (o as BookingQuestionAssignment).QuestionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteStringValue("questionId", QuestionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
