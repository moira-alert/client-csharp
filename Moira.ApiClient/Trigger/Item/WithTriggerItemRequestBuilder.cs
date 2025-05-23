// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Moira.ApiClient.Models.Api;
using Moira.ApiClient.Models.Dto;
using Moira.ApiClient.Trigger.Item.Dump;
using Moira.ApiClient.Trigger.Item.Metrics;
using Moira.ApiClient.Trigger.Item.Render;
using Moira.ApiClient.Trigger.Item.SetMaintenance;
using Moira.ApiClient.Trigger.Item.State;
using Moira.ApiClient.Trigger.Item.Throttling;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Moira.ApiClient.Trigger.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \trigger\{triggerID}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithTriggerItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The dump property</summary>
        public global::Moira.ApiClient.Trigger.Item.Dump.DumpRequestBuilder Dump
        {
            get => new global::Moira.ApiClient.Trigger.Item.Dump.DumpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The metrics property</summary>
        public global::Moira.ApiClient.Trigger.Item.Metrics.MetricsRequestBuilder Metrics
        {
            get => new global::Moira.ApiClient.Trigger.Item.Metrics.MetricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The render property</summary>
        public global::Moira.ApiClient.Trigger.Item.Render.RenderRequestBuilder Render
        {
            get => new global::Moira.ApiClient.Trigger.Item.Render.RenderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The setMaintenance property</summary>
        public global::Moira.ApiClient.Trigger.Item.SetMaintenance.SetMaintenanceRequestBuilder SetMaintenance
        {
            get => new global::Moira.ApiClient.Trigger.Item.SetMaintenance.SetMaintenanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The state property</summary>
        public global::Moira.ApiClient.Trigger.Item.State.StateRequestBuilder State
        {
            get => new global::Moira.ApiClient.Trigger.Item.State.StateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The throttling property</summary>
        public global::Moira.ApiClient.Trigger.Item.Throttling.ThrottlingRequestBuilder Throttling
        {
            get => new global::Moira.ApiClient.Trigger.Item.Throttling.ThrottlingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTriggerItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/trigger/{triggerID}{?populated*,validate*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTriggerItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/trigger/{triggerID}{?populated*,validate*}", rawUrl)
        {
        }
        /// <summary>
        /// Remove trigger
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
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
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get an existing trigger
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.Trigger"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorNotFoundExample">When receiving a 404 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.ApiClient.Models.Dto.Trigger?> GetAsync(Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.ApiClient.Models.Dto.Trigger> GetAsync(Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Moira.ApiClient.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.ApiClient.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.ApiClient.Models.Dto.Trigger>(requestInfo, global::Moira.ApiClient.Models.Dto.Trigger.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update existing trigger
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.SaveTriggerResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Trigger.Item.SaveTriggerResponse400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorNotFoundExample">When receiving a 404 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRemoteServerUnavailableExample">When receiving a 503 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.ApiClient.Models.Dto.SaveTriggerResponse?> PutAsync(global::Moira.ApiClient.Models.Dto.Trigger body, Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.ApiClient.Models.Dto.SaveTriggerResponse> PutAsync(global::Moira.ApiClient.Models.Dto.Trigger body, Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Moira.ApiClient.Trigger.Item.SaveTriggerResponse400Error.CreateFromDiscriminatorValue },
                { "404", global::Moira.ApiClient.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.ApiClient.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
                { "503", global::Moira.ApiClient.Models.Api.ErrorRemoteServerUnavailableExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.ApiClient.Models.Dto.SaveTriggerResponse>(requestInfo, global::Moira.ApiClient.Models.Dto.SaveTriggerResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Remove trigger
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
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// Get an existing trigger
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update existing trigger
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Moira.ApiClient.Models.Dto.Trigger body, Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Moira.ApiClient.Models.Dto.Trigger body, Action<RequestConfiguration<global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder.WithTriggerItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Moira.ApiClient.Trigger.Item.WithTriggerItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get an existing trigger
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithTriggerItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Populated</summary>
            [QueryParameter("populated")]
            public bool? Populated { get; set; }
        }
        /// <summary>
        /// Update existing trigger
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithTriggerItemRequestBuilderPutQueryParameters 
        {
            /// <summary>For validating targets</summary>
            [QueryParameter("validate")]
            public bool? Validate { get; set; }
        }
    }
}
#pragma warning restore CS0618
