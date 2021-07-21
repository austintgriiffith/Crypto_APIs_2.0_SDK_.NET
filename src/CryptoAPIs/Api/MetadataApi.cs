/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: developers@cryptoapis.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace CryptoAPIs.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Supported Assets
        /// </summary>
        /// <remarks>
        /// This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <returns>ListSupportedAssetsR</returns>
        ListSupportedAssetsR ListSupportedAssets(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?));

        /// <summary>
        /// List Supported Assets
        /// </summary>
        /// <remarks>
        /// This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <returns>ApiResponse of ListSupportedAssetsR</returns>
        ApiResponse<ListSupportedAssetsR> ListSupportedAssetsWithHttpInfo(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Supported Assets
        /// </summary>
        /// <remarks>
        /// This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListSupportedAssetsR</returns>
        System.Threading.Tasks.Task<ListSupportedAssetsR> ListSupportedAssetsAsync(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Supported Assets
        /// </summary>
        /// <remarks>
        /// This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListSupportedAssetsR)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListSupportedAssetsR>> ListSupportedAssetsWithHttpInfoAsync(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApi : IMetadataApiSync, IMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MetadataApi : IMetadataApi
    {
        private CryptoAPIs.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi(string basePath)
        {
            this.Configuration = CryptoAPIs.Client.Configuration.MergeConfigurations(
                CryptoAPIs.Client.GlobalConfiguration.Instance,
                new CryptoAPIs.Client.Configuration { BasePath = basePath }
            );
            this.Client = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = CryptoAPIs.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetadataApi(CryptoAPIs.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = CryptoAPIs.Client.Configuration.MergeConfigurations(
                CryptoAPIs.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = CryptoAPIs.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MetadataApi(CryptoAPIs.Client.ISynchronousClient client, CryptoAPIs.Client.IAsynchronousClient asyncClient, CryptoAPIs.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = CryptoAPIs.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public CryptoAPIs.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public CryptoAPIs.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CryptoAPIs.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CryptoAPIs.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// List Supported Assets This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <returns>ListSupportedAssetsR</returns>
        public ListSupportedAssetsR ListSupportedAssets(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?))
        {
            CryptoAPIs.Client.ApiResponse<ListSupportedAssetsR> localVarResponse = ListSupportedAssetsWithHttpInfo(context, assetType, limit, offset);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Supported Assets This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <returns>ApiResponse of ListSupportedAssetsR</returns>
        public CryptoAPIs.Client.ApiResponse<ListSupportedAssetsR> ListSupportedAssetsWithHttpInfo(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?))
        {
            CryptoAPIs.Client.RequestOptions localVarRequestOptions = new CryptoAPIs.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = CryptoAPIs.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CryptoAPIs.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (context != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "context", context));
            }
            if (assetType != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "assetType", assetType));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListSupportedAssetsR>("/market-data/assets/supported", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListSupportedAssets", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Supported Assets This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListSupportedAssetsR</returns>
        public async System.Threading.Tasks.Task<ListSupportedAssetsR> ListSupportedAssetsAsync(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            CryptoAPIs.Client.ApiResponse<ListSupportedAssetsR> localVarResponse = await ListSupportedAssetsWithHttpInfoAsync(context, assetType, limit, offset, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Supported Assets This endpoint will return a list of supported assets. The asset could be a cryptocurrency or FIAT assets that we support. Each asset has a unique identifier - &#x60;assetId&#x60; and a unique symbol in the form of a string, e.g. \&quot;BTC\&quot;.    {note}Please note that listing data from the same type will apply pagination on the results.{/note}
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (optional)</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (optional, default to 50)</param>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (optional, default to 0)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListSupportedAssetsR)</returns>
        public async System.Threading.Tasks.Task<CryptoAPIs.Client.ApiResponse<ListSupportedAssetsR>> ListSupportedAssetsWithHttpInfoAsync(string context = default(string), string assetType = default(string), int? limit = default(int?), int? offset = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            CryptoAPIs.Client.RequestOptions localVarRequestOptions = new CryptoAPIs.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = CryptoAPIs.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CryptoAPIs.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (context != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "context", context));
            }
            if (assetType != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "assetType", assetType));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ListSupportedAssetsR>("/market-data/assets/supported", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListSupportedAssets", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}