using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PlannerPlanDetails : Entity, IParsable {
        /// <summary>An object that specifies the descriptions of the six categories that can be associated with tasks in the plan</summary>
        public PlannerCategoryDescriptions CategoryDescriptions { get; set; }
        /// <summary>Set of user ids that this plan is shared with. If you are leveraging Microsoft 365 groups, use the Groups API to manage group membership to share the group's plan. You can also add existing members of the group to this collection though it is not required for them to access the plan owned by the group.</summary>
        public PlannerUserIds SharedWith { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categoryDescriptions", (o,n) => { (o as PlannerPlanDetails).CategoryDescriptions = n.GetObjectValue<PlannerCategoryDescriptions>(); } },
                {"sharedWith", (o,n) => { (o as PlannerPlanDetails).SharedWith = n.GetObjectValue<PlannerUserIds>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerCategoryDescriptions>("categoryDescriptions", CategoryDescriptions);
            writer.WriteObjectValue<PlannerUserIds>("sharedWith", SharedWith);
        }
    }
}
