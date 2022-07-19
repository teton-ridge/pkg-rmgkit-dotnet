using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
namespace RMGKit.Models
{
    public class MapiAjaxResponse
    {
		public MapiAjaxResponse()
		{
			this.CallResult = 0;
			this.ErrorMessage = String.Empty;
		}
		#region Properties

		[JsonPropertyName("callResult")]
		public int CallResult { get; set; }

		[JsonPropertyName("errorMessage")]
		public string ErrorMessage { get; set; }

		[JsonPropertyName("data")]
		public Object? Data { get; set; }
        #endregion
    }
}
