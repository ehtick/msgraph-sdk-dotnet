using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Users.Item.Teamwork.SendActivityNotification {
    public class SendActivityNotificationRequestBody : IParsable {
        public string ActivityType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public long? ChainId { get; set; }
        public ItemBody PreviewText { get; set; }
        public List<MicrosoftGraph.Models.Microsoft.Graph.KeyValuePair> TemplateParameters { get; set; }
        public TeamworkActivityTopic Topic { get; set; }
        /// <summary>
        /// Instantiates a new sendActivityNotificationRequestBody and sets the default values.
        /// </summary>
        public SendActivityNotificationRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activityType", (o,n) => { (o as SendActivityNotificationRequestBody).ActivityType = n.GetStringValue(); } },
                {"chainId", (o,n) => { (o as SendActivityNotificationRequestBody).ChainId = n.GetLongValue(); } },
                {"previewText", (o,n) => { (o as SendActivityNotificationRequestBody).PreviewText = n.GetObjectValue<ItemBody>(); } },
                {"templateParameters", (o,n) => { (o as SendActivityNotificationRequestBody).TemplateParameters = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.KeyValuePair>().ToList(); } },
                {"topic", (o,n) => { (o as SendActivityNotificationRequestBody).Topic = n.GetObjectValue<TeamworkActivityTopic>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteLongValue("chainId", ChainId);
            writer.WriteObjectValue<ItemBody>("previewText", PreviewText);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
