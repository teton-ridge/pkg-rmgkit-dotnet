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
			this.PlayTime = 0;
		}


		#region Properties


		[JsonPropertyName("play_time")]
		public long PlayTime { get; set; }

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("media_id")]
		public  long MediaID { get; set; }
		#endregion
	}
}