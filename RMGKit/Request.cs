using System;
using System.Net.Http;
using System.Collections.Generic;

namespace RMGKit
{
	/// <summary>
	/// Base request class.
	/// </summary>
	public class Request
	{
		// the base end point
		private string _endpoint = "";

		// additional path info that gets attached to the endpoint
		private string _path = "";

		// the request method 
		private HttpMethod _method = HttpMethod.Get;

		// the request parameter
		private Dictionary<string, Object>? _parameters = null;

		public Request() { }

		public Request(string endpoint)
        {
			this._endpoint = endpoint;
        }

		public Request(string endpoint, string path)
		{
			this._endpoint = endpoint;
			this._path = path;
		}

		public Request(string endpoint, string path, Dictionary<string, Object>? parameters)
		{
			this._endpoint = endpoint;
			this._parameters = parameters;
		}

		public Request(string endpoint, string path, Dictionary<string, Object>? parameters, HttpMethod method)
		{
			this._endpoint = endpoint;
			this._parameters = parameters;
			this._method = method;
		}

		#region Properties

		public string Endpoint
        {
			get { return this._endpoint ?? string.Empty;  }
        }

		public string Path
		{
			get { return this._path ?? string.Empty; }
		}

		public HttpMethod Method
        {
			get { return this._method; }
        }

		public Dictionary<string, Object>? Parameters
		{
			get { return this._parameters; }
		}

		#endregion
	}
}

