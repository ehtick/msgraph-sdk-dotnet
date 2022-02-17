using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Education.Me.Assignments.Item.Submissions.Item.SubmittedResources {
    public class SubmittedResourcesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<EducationSubmissionResource> Value { get; set; }
        /// <summary>
        /// Instantiates a new submittedResourcesResponse and sets the default values.
        /// </summary>
        public SubmittedResourcesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as SubmittedResourcesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as SubmittedResourcesResponse).Value = n.GetCollectionOfObjectValues<EducationSubmissionResource>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<EducationSubmissionResource>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
