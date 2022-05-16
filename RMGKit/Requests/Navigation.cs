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
			public static readonly string get = "navigation";
		}

		public Navigation() { }

		/// <summary>
		/// Builds a navigation get request.
		/// </summary>
		/// <returns></returns>
		public static Request Get() {
			return new Request(Endpoints.get);
		}
	}
}

