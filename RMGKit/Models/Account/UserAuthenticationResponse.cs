using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

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
			this.ShowReset = false;
		}
		#region Properties

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("token")]
		public string Token { get; set; }

		[JsonPropertyName("session_token")]
		public string SessionToken { get; set; }

		[JsonPropertyName("show_reset")]
		public bool ShowReset { get; set; }

		[JsonPropertyName("result")]
		public int Result { get; set; }

		[JsonPropertyName("tags")]
		public List<string> Tags { get; set; }

		[JsonPropertyName("card_data")]
		public string? CardData { get; set; }
		#endregion
	}
}