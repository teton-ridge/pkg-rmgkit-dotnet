using System;

namespace RMGKit.Requests
{
	/// <summary>
	/// Defines navigation requests.
	/// </summary>
	public sealed class Navigation: Request
	{
		/// <summary>
		/// Available Navigation endpoints.
		/// </summary>
		public static class Endpoints
		{
			public static readonly string getNavigation = "device/v2/navigation/";
		}

		public Navigation() { }
		/// <summary>
		/// Builds a navigation get request.
		/// </summary>
		/// <returns></returns>
		public static Request GetNavigation(long id = 0)
		{
			return new Request(Endpoints.getNavigation, id.ToString(), null, System.Net.Http.HttpMethod.Get);
		}
	}
}

