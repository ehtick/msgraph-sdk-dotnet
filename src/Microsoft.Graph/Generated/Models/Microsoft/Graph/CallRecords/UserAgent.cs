using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.CallRecords {
    public class UserAgent : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifies the version of application software used by this endpoint.</summary>
        public string ApplicationVersion { get; set; }
        /// <summary>User-agent header value reported by this endpoint.</summary>
        public string HeaderValue { get; set; }
        /// <summary>
        /// Instantiates a new userAgent and sets the default values.
        /// </summary>
        public UserAgent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationVersion", (o,n) => { (o as UserAgent).ApplicationVersion = n.GetStringValue(); } },
                {"headerValue", (o,n) => { (o as UserAgent).HeaderValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationVersion", ApplicationVersion);
            writer.WriteStringValue("headerValue", HeaderValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
