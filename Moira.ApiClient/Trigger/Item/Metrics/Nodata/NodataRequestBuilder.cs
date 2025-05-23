// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Moira.ApiClient.Models.Api;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Moira.ApiClient.Trigger.Item.Metrics.Nodata
{
    /// <summary>
    /// Builds and executes requests for operations under \trigger\{triggerID}\metrics\nodata
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class NodataRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Trigger.Item.Metrics.Nodata.NodataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NodataRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/trigger/{triggerID}/metrics/nodata", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Trigger.Item.Metrics.Nodata.NodataRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NodataRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/trigger/{triggerID}/metrics/nodata", rawUrl)
        {
        }
        /// <summary>
        /// Delete all metrics from last data which are in NODATA state. It also deletes all trigger patterns of those metrics
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample">When receiving a 400 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorNotFoundExample">When receiving a 404 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample.CreateFromDiscriminatorValue },
                { "404", global::Moira.ApiClient.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete all metrics from last data which are in NODATA state. It also deletes all trigger patterns of those metrics
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Trigger.Item.Metrics.Nodata.NodataRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Moira.ApiClient.Trigger.Item.Metrics.Nodata.NodataRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Moira.ApiClient.Trigger.Item.Metrics.Nodata.NodataRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
