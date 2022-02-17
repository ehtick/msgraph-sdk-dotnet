using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class EducationTeacher : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ID of the teacher in the source system.</summary>
        public string ExternalId { get; set; }
        /// <summary>Teacher number.</summary>
        public string TeacherNumber { get; set; }
        /// <summary>
        /// Instantiates a new educationTeacher and sets the default values.
        /// </summary>
        public EducationTeacher() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"externalId", (o,n) => { (o as EducationTeacher).ExternalId = n.GetStringValue(); } },
                {"teacherNumber", (o,n) => { (o as EducationTeacher).TeacherNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("teacherNumber", TeacherNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
