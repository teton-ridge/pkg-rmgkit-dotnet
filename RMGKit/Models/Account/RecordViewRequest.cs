using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Account
{
	public class RecordViewRequest
	{
		public RecordViewRequest()
		{
			this.Email = "";
			this.MediaID = 0;
			this.ViewID = 0;
			this.PlayTime = 0;
			this.IPAddress = "";
			this.UserAgent = "";
		}


		#region Properties

		[JsonPropertyName("view_id")]
		public long ViewID { get; set; }

		[JsonPropertyName("play_time")]
		public long PlayTime { get; set; }

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("media_id")]
		public  long MediaID { get; set; }
		[JsonPropertyName("ip_address")]
		public string IPAddress { get; set; }
		[JsonPropertyName("user_agent")]
		public string UserAgent { get; set; }
		#endregion
	}
}