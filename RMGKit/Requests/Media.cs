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
			public static readonly string getCategories = "show/GetShows";
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
	}
}

