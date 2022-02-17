using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class BitlockerRecoveryKey : Entity, IParsable {
        /// <summary>The date and time when the key was originally backed up to Azure Active Directory. Not nullable.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Identifier of the device the BitLocker key is originally backed up from. Supports $filter (eq).</summary>
        public string DeviceId { get; set; }
        /// <summary>The BitLocker recovery key. Returned only on $select. Not nullable.</summary>
        public string Key { get; set; }
        /// <summary>Indicates the type of volume the BitLocker key is associated with. The possible values are: 1 (for operatingSystemVolume), 2 (for fixedDataVolume), 3 (for removableDataVolume), and 4 (for unknownFutureValue).</summary>
        public VolumeType? VolumeType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as BitlockerRecoveryKey).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", (o,n) => { (o as BitlockerRecoveryKey).DeviceId = n.GetStringValue(); } },
                {"key", (o,n) => { (o as BitlockerRecoveryKey).Key = n.GetStringValue(); } },
                {"volumeType", (o,n) => { (o as BitlockerRecoveryKey).VolumeType = n.GetEnumValue<VolumeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("key", Key);
            writer.WriteEnumValue<VolumeType>("volumeType", VolumeType);
        }
    }
}
