using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Defines Account requests.
/// </summary>
namespace RMGKit.Requests
{
    /// <summary>
    /// Available media endpoints.
    /// </summary>
    /// public sealed class Media : Request
    public sealed class Content : Request
    {
        public static class Endpoints
        {
            public static readonly string getPage = "device/v2/Content/GetPage/";
        }
		public Content() { }

		/// <summary>
		/// Builds a page request and returns a page object
		/// </summary>
		/// <returns></returns>
		public static Request getPage(string pageSlug="home")
		{
            return new Request(Endpoints.getPage,pageSlug, null, System.Net.Http.HttpMethod.Get) ;
		}
       

        
    }
}
