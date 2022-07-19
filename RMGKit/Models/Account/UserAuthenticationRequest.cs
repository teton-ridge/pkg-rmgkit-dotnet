using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace RMGKit.Models.Account
{
    public class UserAuthenticationRequest
    {
		public UserAuthenticationRequest()
		{
			this.Email = String.Empty;
			this.Password = String.Empty;
			this.Marketing = false;
			this.TargetTags = String.Empty;
		}


		#region Properties

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("password")]
		public string Password { get; set; }
		[JsonPropertyName("marketing")]
		public bool Marketing { get; set; }
		[JsonPropertyName("token")]
		public string? Token { get; set; }
		[JsonPropertyName("target_tags")]
		public string? TargetTags { get; set; }
		#endregion
	}
}