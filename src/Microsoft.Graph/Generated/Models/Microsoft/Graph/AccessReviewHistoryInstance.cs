using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessReviewHistoryInstance : Entity, IParsable {
        /// <summary>Uri which can be used to retrieve review history data. This URI will be active for 24 hours after being generated. Required.</summary>
        public string DownloadUri { get; set; }
        /// <summary>Timestamp when this instance and associated data expires and the history is deleted. Required.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Timestamp when all of the available data for this instance was collected. This will be set after this instance's status is set to done. Required.</summary>
        public DateTimeOffset? FulfilledDateTime { get; set; }
        /// <summary>Timestamp, reviews ending on or before this date will be included in the fetched history data.</summary>
        public DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }
        /// <summary>Timestamp, reviews starting on or after this date will be included in the fetched history data.</summary>
        public DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }
        /// <summary>Timestamp when the instance's history data is scheduled to be generated.</summary>
        public DateTimeOffset? RunDateTime { get; set; }
        /// <summary>Represents the status of the review history data collection. The possible values are: done, inProgress, error, requested, unknownFutureValue. Once the status has been marked as done, a link can be generated to retrieve the instance's data by calling generateDownloadUri method.</summary>
        public AccessReviewHistoryStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"downloadUri", (o,n) => { (o as AccessReviewHistoryInstance).DownloadUri = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as AccessReviewHistoryInstance).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"fulfilledDateTime", (o,n) => { (o as AccessReviewHistoryInstance).FulfilledDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewHistoryPeriodEndDateTime", (o,n) => { (o as AccessReviewHistoryInstance).ReviewHistoryPeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewHistoryPeriodStartDateTime", (o,n) => { (o as AccessReviewHistoryInstance).ReviewHistoryPeriodStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"runDateTime", (o,n) => { (o as AccessReviewHistoryInstance).RunDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as AccessReviewHistoryInstance).Status = n.GetEnumValue<AccessReviewHistoryStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("downloadUri", DownloadUri);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("fulfilledDateTime", FulfilledDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodEndDateTime", ReviewHistoryPeriodEndDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodStartDateTime", ReviewHistoryPeriodStartDateTime);
            writer.WriteDateTimeOffsetValue("runDateTime", RunDateTime);
            writer.WriteEnumValue<AccessReviewHistoryStatus>("status", Status);
        }
    }
}
