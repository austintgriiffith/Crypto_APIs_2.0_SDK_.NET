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
    public interface IValidatingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Validate Address
        /// </summary>
        /// <remarks>
        /// This endpoint checks user public addresses whether they are valid or not.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <returns>ValidateAddressR</returns>
        ValidateAddressR ValidateAddress(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB));

        /// <summary>
        /// Validate Address
        /// </summary>
        /// <remarks>
        /// This endpoint checks user public addresses whether they are valid or not.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <returns>ApiResponse of ValidateAddressR</returns>
        ApiResponse<ValidateAddressR> ValidateAddressWithHttpInfo(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IValidatingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Validate Address
        /// </summary>
        /// <remarks>
        /// This endpoint checks user public addresses whether they are valid or not.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ValidateAddressR</returns>
        System.Threading.Tasks.Task<ValidateAddressR> ValidateAddressAsync(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Validate Address
        /// </summary>
        /// <remarks>
        /// This endpoint checks user public addresses whether they are valid or not.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ValidateAddressR)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidateAddressR>> ValidateAddressWithHttpInfoAsync(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IValidatingApi : IValidatingApiSync, IValidatingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ValidatingApi : IValidatingApi
    {
        private CryptoAPIs.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ValidatingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ValidatingApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ValidatingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ValidatingApi(CryptoAPIs.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ValidatingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ValidatingApi(CryptoAPIs.Client.ISynchronousClient client, CryptoAPIs.Client.IAsynchronousClient asyncClient, CryptoAPIs.Client.IReadableConfiguration configuration)
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
        public String GetBasePath()
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
        /// Validate Address This endpoint checks user public addresses whether they are valid or not.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <returns>ValidateAddressR</returns>
        public ValidateAddressR ValidateAddress(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB))
        {
            CryptoAPIs.Client.ApiResponse<ValidateAddressR> localVarResponse = ValidateAddressWithHttpInfo(blockchain, network, context, validateAddressRB);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validate Address This endpoint checks user public addresses whether they are valid or not.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <returns>ApiResponse of ValidateAddressR</returns>
        public CryptoAPIs.Client.ApiResponse<ValidateAddressR> ValidateAddressWithHttpInfo(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'blockchain' when calling ValidatingApi->ValidateAddress");

            // verify the required parameter 'network' is set
            if (network == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'network' when calling ValidatingApi->ValidateAddress");

            CryptoAPIs.Client.RequestOptions localVarRequestOptions = new CryptoAPIs.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = CryptoAPIs.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CryptoAPIs.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("blockchain", CryptoAPIs.Client.ClientUtils.ParameterToString(blockchain)); // path parameter
            localVarRequestOptions.PathParameters.Add("network", CryptoAPIs.Client.ClientUtils.ParameterToString(network)); // path parameter
            if (context != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "context", context));
            }
            localVarRequestOptions.Data = validateAddressRB;

            // authentication (ApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ValidateAddressR>("/blockchain-tools/{blockchain}/{network}/addresses/validate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Validate Address This endpoint checks user public addresses whether they are valid or not.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ValidateAddressR</returns>
        public async System.Threading.Tasks.Task<ValidateAddressR> ValidateAddressAsync(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            CryptoAPIs.Client.ApiResponse<ValidateAddressR> localVarResponse = await ValidateAddressWithHttpInfoAsync(blockchain, network, context, validateAddressRB, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validate Address This endpoint checks user public addresses whether they are valid or not.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="validateAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ValidateAddressR)</returns>
        public async System.Threading.Tasks.Task<CryptoAPIs.Client.ApiResponse<ValidateAddressR>> ValidateAddressWithHttpInfoAsync(string blockchain, string network, string context = default(string), ValidateAddressRB validateAddressRB = default(ValidateAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'blockchain' when calling ValidatingApi->ValidateAddress");

            // verify the required parameter 'network' is set
            if (network == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'network' when calling ValidatingApi->ValidateAddress");


            CryptoAPIs.Client.RequestOptions localVarRequestOptions = new CryptoAPIs.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = CryptoAPIs.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CryptoAPIs.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("blockchain", CryptoAPIs.Client.ClientUtils.ParameterToString(blockchain)); // path parameter
            localVarRequestOptions.PathParameters.Add("network", CryptoAPIs.Client.ClientUtils.ParameterToString(network)); // path parameter
            if (context != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "context", context));
            }
            localVarRequestOptions.Data = validateAddressRB;

            // authentication (ApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ValidateAddressR>("/blockchain-tools/{blockchain}/{network}/addresses/validate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
