using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.CalendarSharingMessage;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.ManagedAppProtection;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.PrintDocument;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.PrintJob;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.Ref;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.TargetedManagedAppProtection;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WindowsInformationProtection;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRange;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFill;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeSort;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod {
    /// <summary>Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}\lastSharedMethod</summary>
    public class LastSharedMethodRequestBuilder {
        public CalendarSharingMessageRequestBuilder CalendarSharingMessage { get =>
            new CalendarSharingMessageRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedAppProtectionRequestBuilder ManagedAppProtection { get =>
            new ManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileAppContentFileRequestBuilder MobileAppContentFile { get =>
            new MobileAppContentFileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PrintDocumentRequestBuilder PrintDocument { get =>
            new PrintDocumentRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrintJobRequestBuilder PrintJob { get =>
            new PrintJobRequestBuilder(PathParameters, RequestAdapter);
        }
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ScheduleChangeRequestRequestBuilder ScheduleChangeRequest { get =>
            new ScheduleChangeRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        public TargetedManagedAppProtectionRequestBuilder TargetedManagedAppProtection { get =>
            new TargetedManagedAppProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public WindowsInformationProtectionRequestBuilder WindowsInformationProtection { get =>
            new WindowsInformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkbookRangeRequestBuilder WorkbookRange { get =>
            new WorkbookRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkbookRangeFillRequestBuilder WorkbookRangeFill { get =>
            new WorkbookRangeFillRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkbookRangeFormatRequestBuilder WorkbookRangeFormat { get =>
            new WorkbookRangeFormatRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkbookRangeSortRequestBuilder WorkbookRangeSort { get =>
            new WorkbookRangeSortRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkbookRangeViewRequestBuilder WorkbookRangeView { get =>
            new WorkbookRangeViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new LastSharedMethodRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public LastSharedMethodRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/lastSharedMethod{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new LastSharedMethodRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public LastSharedMethodRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/lastSharedMethod{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get lastSharedMethod from me
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get lastSharedMethod from me
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Entity> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Entity>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>Get lastSharedMethod from me</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
