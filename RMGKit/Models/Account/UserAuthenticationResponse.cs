using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;

namespace RMGKit.Models.Account
{
	public class UserAuthenticationResponse
	{
		public UserAuthenticationResponse()
		{
			this.Email = String.Empty;
			this.Token = String.Empty;
			this.SessionToken = String.Empty;
			this.Result = 0;
			this.Tags = new List<string>();
			this.CardData = String.Empty;
			this.FirstName = String.Empty;
			this.LastName = String.Empty;
			this.ShowReset = false;
			this.OnBypass = false;
		}
		#region Properties

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("token")]
		public string Token { get; set; }

		[JsonPropertyName("session_token")]
		public string SessionToken { get; set; }

		[JsonPropertyName("first_name")]
		public string FirstName { get; set; }

		[JsonPropertyName("last_name")]
		public string LastName { get; set; }

		[JsonPropertyName("show_reset")]
		public bool ShowReset { get; set; }

		[JsonPropertyName("result")]
		public int Result { get; set; }

		[JsonPropertyName("on_bypass")]
		public bool OnBypass { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
        [JsonPropertyName("card_data")]
		public string? CardData { get; set; }
		#endregion
	}
}