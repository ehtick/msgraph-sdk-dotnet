using Microsoft.Kiota.Abstractions;
using MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView.Range;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace MicrosoftGraph.Me.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView {
    /// <summary>Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}\lastSharedMethod\microsoft.graph.workbookRangeView</summary>
    public class WorkbookRangeViewRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new WorkbookRangeViewRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeViewRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/lastSharedMethod/microsoft.graph.workbookRangeView";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WorkbookRangeViewRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeViewRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/shared/{sharedInsight_id}/lastSharedMethod/microsoft.graph.workbookRangeView";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Builds and executes requests for operations under \me\insights\shared\{sharedInsight-id}\lastSharedMethod\microsoft.graph.workbookRangeView\microsoft.graph.range()
        /// </summary>
        public RangeRequestBuilder Range() {
            return new RangeRequestBuilder(PathParameters, RequestAdapter);
        }
    }
}
