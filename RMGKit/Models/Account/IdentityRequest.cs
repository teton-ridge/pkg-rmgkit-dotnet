using System;
using System.Text.Json.Serialization;
namespace RMGKit.Models.Account
{
	public class IdentityRequest
	{
		public IdentityRequest()
		{
			this.Token = String.Empty;
		}
		#region Properties
		[JsonPropertyName("token")]
		public string Token { get; set; }
		#endregion
	}
}
