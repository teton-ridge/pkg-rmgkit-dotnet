using System;

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
		public static Request GetShow(int showId)
		{
			return new Request(Endpoints.getShow, $"/{showId}");
		}
	}
}

