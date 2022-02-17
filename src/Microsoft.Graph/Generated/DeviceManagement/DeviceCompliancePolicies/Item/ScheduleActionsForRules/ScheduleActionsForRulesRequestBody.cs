using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.DeviceCompliancePolicies.Item.ScheduleActionsForRules {
    public class ScheduleActionsForRulesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<DeviceComplianceScheduledActionForRule> DeviceComplianceScheduledActionForRules { get; set; }
        /// <summary>
        /// Instantiates a new scheduleActionsForRulesRequestBody and sets the default values.
        /// </summary>
        public ScheduleActionsForRulesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceComplianceScheduledActionForRules", (o,n) => { (o as ScheduleActionsForRulesRequestBody).DeviceComplianceScheduledActionForRules = n.GetCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>("deviceComplianceScheduledActionForRules", DeviceComplianceScheduledActionForRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
