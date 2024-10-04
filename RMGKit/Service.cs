using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace RMGKit
{
	/// <summary>
	/// Represents the primary interface to the API services.
	/// </summary>
	public sealed class Service
	{
		private static Service? __instance = null;
		private string apiUrl = "";
		private string authenticationCode = "";
		private string authenticationKey = "";
		private string applicationIdentifier = "";
		private string applicationVersion = "";
		private string? currentUser;
		private string? currentDeviceToken;
        private string? sip;
        private string? country;
        private Dictionary<string, string>? endpointVersionOverrides = null; 

		public Service() {

		}

		/// <summary>
		/// Convenience constructor.
		/// </summary>
		/// <param name="apiUrl">The api connection's base url (e.g. https://mapi.rfdtv.com).</param>
		/// <param name="authCode">The api connection authentication code.</param>
		/// <param name="authKey">The api connection authentication key.</param>
		/// <param name="appIdentifier">Friendly name that identifies the calling application.</param>
		/// <param name="appVersion">Friendly version string of the calling application in the format PLATFORM SHORT_VER (e.g. iOS 2.0).</param>
		/// <param name="currentUser">The idendifier or the current user; if any.</param>
		/// <param name="currentDeviceToken">The push notification token of the current device; if any.</param>
		/// <param name="endpointOverrides">Overrides for api endpoints. e.g. ["/news": "v6"].</param>
		public Service(
			string apiUrl,
			string authCode,
			string authKey,
			string appIdentifier,
			string appVersion,
			string? currentUser = null,
			string? currentDeviceToken = null,
            string? sip = null,
            string? country = null,
            Dictionary<string, string>? endpointOverrides = null)
		{
			this.apiUrl = apiUrl;
			this.authenticationCode = authCode;
			this.authenticationKey = authKey;
			this.applicationIdentifier = appIdentifier;
			this.applicationVersion = appVersion;
			this.currentUser = currentUser;
			this.currentDeviceToken = currentDeviceToken;
			this.endpointVersionOverrides = endpointOverrides;
			this.sip = sip;
			this.country = country;
        }

		/// <summary>
		/// Shared singleton instance of api service.
		/// </summary>
		public static Service shared
		{
			get
			{
				if (__instance == null)
					__instance = new Service();
				return __instance;
			}
		}

		/// <summary>
		/// Configures the api service connection.
		/// </summary>
		/// <param name="apiUrl">The api connection's base url (e.g. https://mapi.rfdtv.com).</param>
		/// <param name="authCode">The api connection authentication code.</param>
		/// <param name="authKey">The api connection authentication key.</param>
		/// <param name="appIdentifier">Friendly name that identifies the calling application.</param>
		/// <param name="appVersion">Friendly version string of the calling application in the format PLATFORM SHORT_VER (e.g. iOS 2.0).</param>
		/// <param name="currentUser">The idendifier or the current user; if any.</param>
		/// <param name="currentDeviceToken">The push notification token of the current device; if any.</param>
		/// <param name="endpointOverrides">Overrides for api endpoints. e.g. ["/news": "v6"].</param>
		public void Configure(
			string apiUrl,
			string authCode,
			string authKey,
			string appIdentifier,
			string appVersion,
			string? currentUser = null,
			string? currentDeviceToken = null,
			Dictionary<string, string>? endpointOverrides = null)
		{
			this.apiUrl = apiUrl;
			this.authenticationCode = authCode;
			this.authenticationKey = authKey;
			this.applicationIdentifier = appIdentifier;
			this.applicationVersion = appVersion;
			this.currentUser = currentUser;
			this.currentDeviceToken = currentDeviceToken;
			this.endpointVersionOverrides = endpointOverrides;
		}

		#region Properties

		/// <summary>
		/// Gets or sets the current user identity.
		/// </summary>
		public string? Username
		{
			get
			{
				return this.currentUser;
			}
			set
			{
				this.currentUser = value;
			}
		}

		/// <summary>
		/// Gets or sets the current push notification token.
		/// </summary>
		public string? DeviceToken
		{
			get
			{
				return this.currentDeviceToken;
			}
			set
			{
				this.currentDeviceToken = value;
			}
		}

		#endregion

		#region Requests

		private Dictionary<string,string> DefaultRequestHeaders()
        {
			return new Dictionary<string, string>
			{
				{ "Accept", "application/json" },
				{ "X-APIKey", $"{this.authenticationCode}:{this.authenticationKey}" },
				{ "X-Property", this.applicationIdentifier },
				{ "X-App-Ver", this.applicationVersion },
				{ "X-UserName", (this.currentUser ?? "") },
				{ "X-UserToken", "" },
				{ "X-Device", (this.currentDeviceToken ?? "") },
				{ "X-Sip", (this.sip ?? "") },
				{ "X-Country", (this.country ?? "") }
            };
        }

		private string BuildRequestURL(string endpoint)
		{
			if (this.endpointVersionOverrides != null && this.endpointVersionOverrides.Count > 0)
			{
				if (this.endpointVersionOverrides.ContainsKey(endpoint))
				{
					return $"{this.apiUrl}/api/{this.endpointVersionOverrides[endpoint]}/{endpoint}";
				}
			}
			return $"{this.apiUrl}/api/{endpoint}";
		}

		/// <summary>
        /// Fetch delegate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
		public delegate void FetchDelegate<T>(T? response) where T : class;

		/// <summary>
		/// Submits a api service request that returns data.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="request">The api request definition.</param>
		/// <param name="onComplete">The request callback handler.</param>
		public async void Fetch<T>(Request request, FetchDelegate<T> onComplete, RMGKit.Models.Common.CallerIdentity? caller) where T : class {
			var result = await Fetch<T>(request, caller);
			onComplete(result);
		}

		/// <summary>
		/// Creates an api request task that returns data.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="request"></param>
		/// <returns></returns>
		public Task<T?> Fetch<T>(Request request,RMGKit.Models.Common.CallerIdentity? caller ) where T : class
		{
			HttpMethod _method = request.Method;
			request.setIdentity(caller ?? new RMGKit.Models.Common.CallerIdentity());
			if (request.Method == HttpMethod.Post)
				return Post<T>(request);
			else
				return Get<T>(request);
		}

		#endregion

		#region Requests (Private)

		// perform a get request
		private async Task<T?> Get<T>(Request request) where T : class
		{
			string _url = BuildRequestURL(request.Endpoint) + request.Path;
			Dictionary<string, Object> _params = request.Parameters ?? new Dictionary<string, Object>();
			Dictionary<string, string> _headers = DefaultRequestHeaders();

			var client = new RestClient();
			var restRequest = new RestSharp.RestRequest(_url, Method.Get);

			restRequest.AddHeaders(_headers);
			//restRequest.AddObject(_params);
			// todo: need to work out how to use parameters

			
			foreach (var key in _params.Keys)
			{
				if (key == "username")
				{
					var value = _params[key];
					restRequest.AddOrUpdateHeader("X-UserName", value.ToString());

				}
				if (key == "usertoken")
				{
					var value = _params[key];
					restRequest.AddOrUpdateHeader("X-UserToken", value.ToString());
				}
				if (key == "devicetoken")
				{
					var value = _params[key];
					restRequest.AddOrUpdateHeader("X-Device", value.ToString());
				}
                if (key == "sip")
                {
                    var value = _params[key];
                    restRequest.AddOrUpdateHeader("X-Sip", value.ToString());
                }
                if (key == "country")
                {
                    var value = _params[key];
                    restRequest.AddOrUpdateHeader("X-Country", value.ToString());
                }
            }
			return await client.GetAsync<T?>(restRequest);
		}

		// perform a get request
		private async Task<T?> Post<T>(Request request) where T : class
		{
			string _url = BuildRequestURL(request.Endpoint) + request.Path;
			Dictionary<string, Object> _params = request.Parameters ?? new Dictionary<string, Object>();
			Dictionary<string, string> _headers = DefaultRequestHeaders();

			var client = new RestClient();
			var restRequest = new RestSharp.RestRequest(_url, Method.Post);
			 
			restRequest.AddHeaders(_headers);
			
			//restRequest.AddObject(_params);


			// todo: need to work out how to use parameters
			// Look for a parameter called "jsonbody"

			foreach (var key in _params.Keys)
            {					
				if (key == "jsonbody")
				{
					var value = _params[key];
					restRequest.AddJsonBody(value);

				}
				if (key == "username")
				{
					var value = _params[key];
					restRequest.AddOrUpdateHeader("X-UserName", value.ToString());

				}
				if (key == "usertoken")
				{
					var value = _params[key];
					restRequest.AddOrUpdateHeader("X-UserToken", value.ToString());
				}
				if (key == "devicetoken")
				{
					var value = _params[key];
					restRequest.AddOrUpdateHeader("X-Device", value.ToString());
				}
                if (key == "sip")
                {
                    var value = _params[key];
                    restRequest.AddOrUpdateHeader("X-Sip", value.ToString());
                }
                if (key == "country")
                {
                    var value = _params[key];
                    restRequest.AddOrUpdateHeader("X-Country", value.ToString());
                }
            } 
			return await client.PostAsync<T?>(restRequest);
		}

        #endregion

    }

}

