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
            public static readonly string getEPG = "device/v2/Content/getguide/";
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
        public static Request getSearchPage(string term = "",int start=0, int pageLength = 50)
        {
            return new Request(Endpoints.getPage, "?slug=search&term="+ term + "&start=" + start.ToString() + "&count=" + pageLength.ToString(), null, System.Net.Http.HttpMethod.Get);
        }
        public static Request getGuide()
        {
            return new Request(Endpoints.getEPG, "", null, System.Net.Http.HttpMethod.Get);
        }

    }
}
