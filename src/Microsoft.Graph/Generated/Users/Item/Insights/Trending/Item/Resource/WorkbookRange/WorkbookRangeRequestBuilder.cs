using Microsoft.Kiota.Abstractions;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.BoundingRectWithAnotherRange;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.CellWithRowWithColumn;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Clear;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsAfter;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsAfterWithCount;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsBefore;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsBeforeWithCount;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnWithColumn;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Delete;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.EntireColumn;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.EntireRow;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Insert;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.IntersectionWithAnotherRange;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.LastCell;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.LastColumn;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.LastRow;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Merge;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.OffsetRangeWithRowOffsetWithColumnOffset;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ResizedRangeWithDeltaRowsWithDeltaColumns;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsAbove;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsAboveWithCount;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsBelow;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsBelowWithCount;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowWithRow;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Unmerge;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.UsedRange;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.UsedRangeWithValuesOnly;
using MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.VisibleView;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace MicrosoftGraph.Users.Item.Insights.Trending.Item.Resource.WorkbookRange {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange</summary>
    public class WorkbookRangeRequestBuilder {
        public ClearRequestBuilder Clear { get =>
            new ClearRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeleteRequestBuilder Delete { get =>
            new DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        public InsertRequestBuilder Insert { get =>
            new InsertRequestBuilder(PathParameters, RequestAdapter);
        }
        public MergeRequestBuilder Merge { get =>
            new MergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public UnmergeRequestBuilder Unmerge { get =>
            new UnmergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.boundingRect(anotherRange='{anotherRange}')
        /// <param name="anotherRange">Usage: anotherRange={anotherRange}</param>
        /// </summary>
        public BoundingRectWithAnotherRangeRequestBuilder BoundingRectWithAnotherRange(string anotherRange) {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new BoundingRectWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.cell(row={row},column={column})
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        /// </summary>
        public CellWithRowWithColumnRequestBuilder CellWithRowWithColumn(int? row, int? column) {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new CellWithRowWithColumnRequestBuilder(PathParameters, RequestAdapter, row, column);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsAfter()
        /// </summary>
        public ColumnsAfterRequestBuilder ColumnsAfter() {
            return new ColumnsAfterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsAfter(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public ColumnsAfterWithCountRequestBuilder ColumnsAfterWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new ColumnsAfterWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsBefore()
        /// </summary>
        public ColumnsBeforeRequestBuilder ColumnsBefore() {
            return new ColumnsBeforeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsBefore(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public ColumnsBeforeWithCountRequestBuilder ColumnsBeforeWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new ColumnsBeforeWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.column(column={column})
        /// <param name="column">Usage: column={column}</param>
        /// </summary>
        public ColumnWithColumnRequestBuilder ColumnWithColumn(int? column) {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            return new ColumnWithColumnRequestBuilder(PathParameters, RequestAdapter, column);
        }
        /// <summary>
        /// Instantiates a new WorkbookRangeRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/trending/{trending_id}/resource/microsoft.graph.workbookRange";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WorkbookRangeRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/trending/{trending_id}/resource/microsoft.graph.workbookRange";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.entireColumn()
        /// </summary>
        public EntireColumnRequestBuilder EntireColumn() {
            return new EntireColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.entireRow()
        /// </summary>
        public EntireRowRequestBuilder EntireRow() {
            return new EntireRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.intersection(anotherRange='{anotherRange}')
        /// <param name="anotherRange">Usage: anotherRange={anotherRange}</param>
        /// </summary>
        public IntersectionWithAnotherRangeRequestBuilder IntersectionWithAnotherRange(string anotherRange) {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new IntersectionWithAnotherRangeRequestBuilder(PathParameters, RequestAdapter, anotherRange);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.lastCell()
        /// </summary>
        public LastCellRequestBuilder LastCell() {
            return new LastCellRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.lastColumn()
        /// </summary>
        public LastColumnRequestBuilder LastColumn() {
            return new LastColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.lastRow()
        /// </summary>
        public LastRowRequestBuilder LastRow() {
            return new LastRowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.offsetRange(rowOffset={rowOffset},columnOffset={columnOffset})
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        /// </summary>
        public OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder OffsetRangeWithRowOffsetWithColumnOffset(int? rowOffset, int? columnOffset) {
            _ = columnOffset ?? throw new ArgumentNullException(nameof(columnOffset));
            _ = rowOffset ?? throw new ArgumentNullException(nameof(rowOffset));
            return new OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(PathParameters, RequestAdapter, rowOffset, columnOffset);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.resizedRange(deltaRows={deltaRows},deltaColumns={deltaColumns})
        /// <param name="deltaColumns">Usage: deltaColumns={deltaColumns}</param>
        /// <param name="deltaRows">Usage: deltaRows={deltaRows}</param>
        /// </summary>
        public ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder ResizedRangeWithDeltaRowsWithDeltaColumns(int? deltaRows, int? deltaColumns) {
            _ = deltaColumns ?? throw new ArgumentNullException(nameof(deltaColumns));
            _ = deltaRows ?? throw new ArgumentNullException(nameof(deltaRows));
            return new ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(PathParameters, RequestAdapter, deltaRows, deltaColumns);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsAbove()
        /// </summary>
        public RowsAboveRequestBuilder RowsAbove() {
            return new RowsAboveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsAbove(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public RowsAboveWithCountRequestBuilder RowsAboveWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new RowsAboveWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsBelow()
        /// </summary>
        public RowsBelowRequestBuilder RowsBelow() {
            return new RowsBelowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsBelow(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public RowsBelowWithCountRequestBuilder RowsBelowWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new RowsBelowWithCountRequestBuilder(PathParameters, RequestAdapter, count);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.row(row={row})
        /// <param name="row">Usage: row={row}</param>
        /// </summary>
        public RowWithRowRequestBuilder RowWithRow(int? row) {
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new RowWithRowRequestBuilder(PathParameters, RequestAdapter, row);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.usedRange()
        /// </summary>
        public UsedRangeRequestBuilder UsedRange() {
            return new UsedRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.usedRange(valuesOnly={valuesOnly})
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        /// </summary>
        public UsedRangeWithValuesOnlyRequestBuilder UsedRangeWithValuesOnly(bool? valuesOnly) {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new UsedRangeWithValuesOnlyRequestBuilder(PathParameters, RequestAdapter, valuesOnly);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.visibleView()
        /// </summary>
        public VisibleViewRequestBuilder VisibleView() {
            return new VisibleViewRequestBuilder(PathParameters, RequestAdapter);
        }
    }
}
