using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DataSubject : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Email of the data subject.</summary>
        public string Email { get; set; }
        /// <summary>First name of the data subject.</summary>
        public string FirstName { get; set; }
        /// <summary>Last Name of the data subject.</summary>
        public string LastName { get; set; }
        /// <summary>The country/region of residency. The residency information is uesed only for internal reporting but not for the content search.</summary>
        public string Residency { get; set; }
        /// <summary>
        /// Instantiates a new dataSubject and sets the default values.
        /// </summary>
        public DataSubject() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"email", (o,n) => { (o as DataSubject).Email = n.GetStringValue(); } },
                {"firstName", (o,n) => { (o as DataSubject).FirstName = n.GetStringValue(); } },
                {"lastName", (o,n) => { (o as DataSubject).LastName = n.GetStringValue(); } },
                {"residency", (o,n) => { (o as DataSubject).Residency = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteStringValue("residency", Residency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
