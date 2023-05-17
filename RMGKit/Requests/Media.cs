using System;
using System.Collections.Generic;
using System.Text;

namespace RMGKit.Requests
{
	/// <summary>
	/// Defines media requests.
	/// </summary>
	public sealed class Media : Request
	{
		/// <summary>
		/// Available media endpoints.
		/// </summary>
		public static class Endpoints
		{
			public static readonly string getCategories = "device/v2/Show/GetShows";
			public static readonly string getShow = "device/v2/Show/GetShow";
            public static readonly string getShowByTag = "device/v2/Show/GetShowByTag";
            public static readonly string getMedia = "device/v2/Media/GetMedia";
			public static readonly string getStream = "device/v2/Media/GetStream";
			public static readonly string getJWMedia = "device/v2/Media/GetJWMedia";
		}

		public Media() { }

		/// <summary>
		/// Builds a get media categories request.
		/// </summary>
		/// <returns></returns>
		public static Request GetCategories()
		{
			return new Request(Endpoints.getCategories);
		}

		/// <summary>EW
		/// Builds a get media categories request.
		/// </summary>
		/// <returns></returns>
		public static Request GetShow(long showId)
		{
			return new Request(Endpoints.getShow, $"/{showId}");
		}
        public static Request GetShowByTag(string showTag)
        {
            return new Request(Endpoints.getShowByTag, $"/{showTag}");
        }

        /// <summary>EW
        /// Builds a get media categories request.
        /// </summary>
        /// <returns></returns>
        public static Request GetMedia(RMGKit.Models.Media.MediaRequest param)
		{
			var parameters = new Dictionary<string, Object>();
			if (param != null)
			{
				parameters.Add("jsonbody", param);
			}
			return new Request(Endpoints.getMedia, $"", parameters, System.Net.Http.HttpMethod.Post);
		}
		/// <summary>EW
		/// Builds a get media categories request.
		/// </summary>
		/// <returns></returns>
		public static Request GetStream(RMGKit.Models.Media.MediaRequest param)
		{
			var parameters = new Dictionary<string, Object>();
			if (param != null)
			{
				parameters.Add("jsonbody", param);
			}
			return new Request(Endpoints.getStream, $"", parameters, System.Net.Http.HttpMethod.Post);
		}
		/// <summary>EW
		/// Builds a get media categories request.
		/// </summary>
		/// <returns></returns>
		public static Request GetJWMedia(RMGKit.Models.Media.MediaRequest param)
		{
			var parameters = new Dictionary<string, Object>();
			if (param != null)
			{
				parameters.Add("jsonbody", param);
			}
			return new Request(Endpoints.getJWMedia, $"", parameters, System.Net.Http.HttpMethod.Post);
		}
	}
}

