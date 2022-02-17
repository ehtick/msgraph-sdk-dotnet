using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ConditionalAccessGrantControls : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.</summary>
        public List<ConditionalAccessGrantControl?> BuiltInControls { get; set; }
        /// <summary>List of custom controls IDs required by the policy. For more information, see Custom controls.</summary>
        public List<string> CustomAuthenticationFactors { get; set; }
        /// <summary>Defines the relationship of the grant controls. Possible values: AND, OR.</summary>
        public string Operator { get; set; }
        /// <summary>List of terms of use IDs required by the policy.</summary>
        public List<string> TermsOfUse { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessGrantControls and sets the default values.
        /// </summary>
        public ConditionalAccessGrantControls() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"builtInControls", (o,n) => { (o as ConditionalAccessGrantControls).BuiltInControls = n.GetCollectionOfEnumValues<ConditionalAccessGrantControl>().ToList(); } },
                {"customAuthenticationFactors", (o,n) => { (o as ConditionalAccessGrantControls).CustomAuthenticationFactors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"operator", (o,n) => { (o as ConditionalAccessGrantControls).Operator = n.GetStringValue(); } },
                {"termsOfUse", (o,n) => { (o as ConditionalAccessGrantControls).TermsOfUse = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<ConditionalAccessGrantControl>("builtInControls", BuiltInControls);
            writer.WriteCollectionOfPrimitiveValues<string>("customAuthenticationFactors", CustomAuthenticationFactors);
            writer.WriteStringValue("operator", Operator);
            writer.WriteCollectionOfPrimitiveValues<string>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
