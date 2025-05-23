// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Moira.ApiClient.Models.Api;
using Moira.ApiClient.Models.Dto;
using Moira.ApiClient.Subscription.Item.Test;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Moira.ApiClient.Subscription.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \subscription\{subscriptionID}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithSubscriptionItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The test property</summary>
        public global::Moira.ApiClient.Subscription.Item.Test.TestRequestBuilder Test
        {
            get => new global::Moira.ApiClient.Subscription.Item.Test.TestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Subscription.Item.WithSubscriptionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSubscriptionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/subscription/{subscriptionID}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Moira.ApiClient.Subscription.Item.WithSubscriptionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSubscriptionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/subscription/{subscriptionID}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a subscription
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorForbiddenExample">When receiving a 403 status code</exception>
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
                { "403", global::Moira.ApiClient.Models.Api.ErrorForbiddenExample.CreateFromDiscriminatorValue },
                { "404", global::Moira.ApiClient.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get subscription by id
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.Subscription"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorForbiddenExample">When receiving a 403 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorNotFoundExample">When receiving a 404 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.ApiClient.Models.Dto.Subscription?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.ApiClient.Models.Dto.Subscription> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "403", global::Moira.ApiClient.Models.Api.ErrorForbiddenExample.CreateFromDiscriminatorValue },
                { "404", global::Moira.ApiClient.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.ApiClient.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.ApiClient.Models.Dto.Subscription>(requestInfo, global::Moira.ApiClient.Models.Dto.Subscription.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a subscription
        /// </summary>
        /// <returns>A <see cref="global::Moira.ApiClient.Models.Dto.Subscription"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample">When receiving a 400 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorForbiddenExample">When receiving a 403 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorNotFoundExample">When receiving a 404 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorRenderExample">When receiving a 422 status code</exception>
        /// <exception cref="global::Moira.ApiClient.Models.Api.ErrorInternalServerExample">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Moira.ApiClient.Models.Dto.Subscription?> PutAsync(global::Moira.ApiClient.Models.Dto.Subscription body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Moira.ApiClient.Models.Dto.Subscription> PutAsync(global::Moira.ApiClient.Models.Dto.Subscription body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Moira.ApiClient.Models.Api.ErrorInvalidRequestExample.CreateFromDiscriminatorValue },
                { "403", global::Moira.ApiClient.Models.Api.ErrorForbiddenExample.CreateFromDiscriminatorValue },
                { "404", global::Moira.ApiClient.Models.Api.ErrorNotFoundExample.CreateFromDiscriminatorValue },
                { "422", global::Moira.ApiClient.Models.Api.ErrorRenderExample.CreateFromDiscriminatorValue },
                { "500", global::Moira.ApiClient.Models.Api.ErrorInternalServerExample.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Moira.ApiClient.Models.Dto.Subscription>(requestInfo, global::Moira.ApiClient.Models.Dto.Subscription.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a subscription
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
        /// Get subscription by id
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update a subscription
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Moira.ApiClient.Models.Dto.Subscription body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Moira.ApiClient.Models.Dto.Subscription body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Moira.ApiClient.Subscription.Item.WithSubscriptionItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Moira.ApiClient.Subscription.Item.WithSubscriptionItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Moira.ApiClient.Subscription.Item.WithSubscriptionItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
